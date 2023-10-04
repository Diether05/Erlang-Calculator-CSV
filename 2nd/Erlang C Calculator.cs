using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Windows.Forms;



namespace _2nd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // set the AcceptButton property of the form to the button you want to click when the user presses Enter
            this.AcceptButton = calculate_btn;

            // set the DialogResult property of the button to OK
            calculate_btn.DialogResult = DialogResult.OK;

            //hide save button first
            save_btn.Visible = false;
            label5.Visible = false;

            // intitialize variables
            string num_calls_1 = "";
            int aht = 260;
            float req_sla = 90;
            float shrinkage = 5;
            period_combo_bx.SelectedIndex = 0;
            TAT_combo_bx.SelectedIndex = 3;

            //text box default value
            filePathTextBox.Text = num_calls_1.ToString();
            req_sla_bx.Text = req_sla.ToString();
            AHT_s_bx.Text = aht.ToString();
            shrinkage_bx.Text = shrinkage.ToString();

            label5.Visible = false;
            dateTimePicker1.Value = DateTime.Today;

            dataGridView1.Rows.Clear();

            OnlyAllow3DigitNumbers(AHT_s_bx);
            OnlyAllowNumbersBetween1And100(req_sla_bx);
            OnlyAllowNumbersBetween1And100(shrinkage_bx);

        }

        private void calculate_btn_Click_1(object sender, EventArgs e)
        {
            // enable save button and loadung indicator when calculate is click
            calculate_btn.Enabled = false;
            clear_btn.Enabled = false;
            select_btn.Enabled = false;
            save_btn.Enabled = false;

            //read csv lines using try catch. prompt errror when file is empty or incorrect
            try
            {
                string path = filePathTextBox.Text;

                //split csv per column
                string[][] test = File.ReadAllLines(path).Select(line => line.Split(',')).ToArray();

                //datetime pickeg
                string DateCol = dateTimePicker1.Text.ToString();
                label5.Text = dateTimePicker1.Value.ToLongDateString();

                //get the column equal to datetime picker
                int columnIndex = Array.IndexOf(test[0], DateCol);

                // Do something with the column data
                if (columnIndex <= 0)
                {
                    // Handle the case where the column header is not found
                    calculate_btn.Enabled = false;
                    clear_btn.Enabled = false;
                    select_btn.Enabled = false;
                    save_btn.Enabled = false;
                    MessageBox.Show("Column not found.");

                }


                //split csv columns 
                string[] first = test.Select(row => row[0]).ToArray(); //row header
                string[] second = test.Select(row => row[columnIndex]).ToArray(); //value column


                //Row header value
                string[] header = { "Call Volume", "Additional Agents", "Traffic Intensity(A)", "Raw Agents(N)", "Probabilty of Waiting (Pw)", "SLA", "ASA", "% Calls Answered Immediately", "Maximum Occupancy", "No. of Required Agents(W/Shrinkage)" };


                //loop for every value in csv
                for (int x = 1; x < test.Length; x++)
                {
                    string[] result = new string[10];

                    // read the csv cells except header

                    float num_calls = float.Parse(second[x]);
                    double sl = 0;
                    double sla = double.Parse(req_sla_bx.Text) / 100;
                    int additional = 0;
                    int volumecalls = 0;

                    while (sla >= sl)
                    {
                        // calculation happen here

                        // parse variable
                        if (num_calls <= 1)
                        {
                            additional = 1;
                        }
                        float aht = float.Parse(AHT_s_bx.Text);
                        float shrinkage = float.Parse(shrinkage_bx.Text);
                        float period = 60 * Convert.ToInt16(period_combo_bx.SelectedItem.ToString());
                        //int additional = int.Parse(add_agent_bx.Text);


                        //result variable
                        if (num_calls % 45 == 0)
                        {
                            num_calls = float.Parse(Convert.ToString((num_calls + 0.0001))); // to prevent overflow
                        }
                        volumecalls = Convert.ToInt16(num_calls);
                        float A = (num_calls * aht) / period;
                        int A_int = Convert.ToInt16(A);
                        int N = Convert.ToInt16(A) + additional;

                        //Probability of waiting variables
                        int number = N;
                        BigInteger Nfact = Factorial(number);
                        double power = Math.Pow(A, number);
                        double x1 = power / double.Parse(Nfact.ToString());
                        double x2 = (number / (number - A));
                        double y = summation(A, number);
                        double Pw = ((x2 * x1) / (y + (x2 * x1)));                            //important

                        //Service Level Variables
                        int tats = Convert.ToInt16(TAT_combo_bx.SelectedItem.ToString());
                        double exp = -1 * ((number - A) * (tats / aht));
                        double euler = Math.Exp(exp);
                        sl = 1 - (Pw * euler);                           //important


                        //Average Speed of Answer
                        double asa = (Pw * aht) / (N - A);                           //important

                        //percentage of calls answered immediately
                        double imm_answ = (1 - Pw) * 100;                           //important

                        //maximum occupancy
                        double occ = (A / N) * 100;                           //important

                        //shrinkage factor
                        double req = N / (1 - (shrinkage / 100));                           //important

                        result[0] = volumecalls.ToString();
                        result[1] = additional.ToString();
                        result[2] = A_int.ToString();
                        result[3] = Convert.ToInt16(N).ToString();
                        result[4] = (Pw * 100).ToString("F2") + "%";
                        result[5] = (sl * 100).ToString("F2") + "%";
                        result[6] = asa.ToString("F1") + " (s)";
                        result[7] = imm_answ.ToString("N2") + "%";
                        result[8] = occ.ToString("F2") + "%";
                        result[9] = Convert.ToInt16(req).ToString();



                        additional++; // increment while sla >= sl
                    }
                    //data grid view
                    foreach (DataGridViewColumn col in dataGridView1.Columns)
                    {
                        col.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }

                    dataGridView1.ColumnCount = second.Length;
                    dataGridView1.RowCount = result.Length;
                    dataGridView1.Columns[x - 1].Name = first[x];



                    for (int i = 0; i < 10; i++)
                    {
                        //dataGridView1.Rows.Add(result[i]);

                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells[x - 1].Value = result[i];
                        dataGridView1.Rows[i].HeaderCell.Value = header[i];
                    }
                }


                label5.Visible = true;

                MessageBox.Show("Done!");

                //hide button or label
                save_btn.Visible = true;
                save_btn.Enabled = true;
                calculate_btn.Enabled = true;
                clear_btn.Enabled = true;
                select_btn.Enabled = true;

                // Process the file data
            }

            catch (ArgumentNullException)
            {
                // Handle case when file path is empty
                save_btn.Visible = false;
                label5.Visible = false;
                MessageBox.Show("Please select a file.");
                calculate_btn.Enabled = true;
                clear_btn.Enabled = true;
                select_btn.Enabled = true;
                save_btn.Enabled = true;
            }
            catch (FileNotFoundException)
            {
                // Handle case when file is not found
                label5.Visible = false;
                MessageBox.Show("File not found. Please select a valid file.");
                calculate_btn.Enabled = true;
                clear_btn.Enabled = true;
                select_btn.Enabled = true;
                save_btn.Enabled = true;
            }
            catch (Exception ex)
            {
                // Handle any other exceptions
                label5.Visible = false;
                MessageBox.Show("Error: " + ex.Message);
                calculate_btn.Enabled = true;
                clear_btn.Enabled = true;
                select_btn.Enabled = true;
                save_btn.Enabled = true;
            }
        }

        private double summation(double A2, double N2)
        {
            double numTerms = N2;
            double sum = 0.0;


            for (int i = 0; i < numTerms; i++)
            {
                BigInteger factsum = Factorial(i);
                double denom = double.Parse(factsum.ToString());
                double poww = Math.Pow(A2, i);
                double term = poww / denom;
                sum += term;
            }

            return sum;
        }

        private BigInteger Factorial(int number) //factorial function
        {
            BigInteger fact = 1;

            if (number == 0)
            {
                return 1;
            }
            else
            {
                for (int i = number; i > 0; i--)
                {
                    fact *= i;
                }

                return fact;

            }
        }


        private void clear_btn_Click_1(object sender, EventArgs e)
        {
            // clear text box value
            // intitialize variables
            string num_calls = "";
            //int period = 0;
            int aht = 260;
            float req_sla = 90;
            //int tat = 0;
            float shrinkage = 5;
            period_combo_bx.SelectedIndex = 0;
            TAT_combo_bx.SelectedIndex = 3;

            //text box default value

            filePathTextBox.Text = num_calls.ToString();
            req_sla_bx.Text = req_sla.ToString();
            AHT_s_bx.Text = aht.ToString();
            shrinkage_bx.Text = shrinkage.ToString();
            period_combo_bx.SelectedIndex = 0;
            TAT_combo_bx.SelectedIndex = 3;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            //hide save button
            label5.Visible = false;
            save_btn.Visible = false;
        }

        private void select_btn_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files|*.csv";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePathTextBox.Text = openFileDialog.FileName;
            }

        }

        private void save_btn_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "CSV file (*.csv)|*.csv";
                saveFileDialog1.Title = "Save as CSV file";
                saveFileDialog1.ShowDialog();

                if (saveFileDialog1.FileName != "")
                {

                    var headers = dataGridView1.Columns.Cast<DataGridViewColumn>();
                    var rows = dataGridView1.Rows.Cast<DataGridViewRow>().Select(r =>
                        headers.Select(h => string.Format("\"{0}\"", r.Cells[h.Index].Value)).ToArray());

                    var csv = new StringBuilder();

                    csv.AppendLine(string.Join(",", headers.Select(h => string.Format("\"{0}\"", h.HeaderText))));

                    foreach (var row in rows)
                    {
                        csv.AppendLine(string.Join(",", row));
                    }


                    File.WriteAllText(saveFileDialog1.FileName, csv.ToString());
                    MessageBox.Show("File saved successfully.", "Save Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
                MessageBox.Show("No data to save.");
        }
        //end save_btn

        public void OnlyAllow3DigitNumbers(TextBox textBox)     //check the text box input only accept 3 digit maximum only
        {
            textBox.KeyPress += (sender, e) =>
            {
                // Check if the key pressed is a digit or a control key
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    // If the key pressed is not a digit or a control key, set the Handled property to true
                    e.Handled = true;
                }
                else if (char.IsDigit(e.KeyChar))
                {
                    // If the key pressed is a digit, check if the resulting text is a valid 3-digit number
                    string newText = textBox.Text + e.KeyChar;
                    if (newText.Length > 3 || !int.TryParse(newText, out int result))
                    {
                        // If the resulting text is not a valid 3-digit number, set the Handled property to true
                        e.Handled = true;
                    }
                }
            };
        }

        public void OnlyAllowNumbersBetween1And100(TextBox textBox)
        {
            textBox.KeyPress += (sender, e) =>
            {
                // Check if the key pressed is a digit or a control key
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    // If the key pressed is not a digit or a control key, set the Handled property to true
                    e.Handled = true;
                }
                else if (char.IsDigit(e.KeyChar))
                {
                    // If the key pressed is a digit, check if the resulting text is a valid number between 1 and 100
                    string newText = textBox.Text + e.KeyChar;
                    if (!int.TryParse(newText, out int result) || result < 1 || result > 100)
                    {
                        // If the resulting text is not a valid number between 1 and 100, set the Handled property to true
                        e.Handled = true;
                    }
                }
            };
        }
   }
}

