using System.Windows.Forms;

namespace _2nd
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.save_btn = new System.Windows.Forms.Button();
            this.select_btn = new System.Windows.Forms.Button();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.shrinkage_bx = new System.Windows.Forms.TextBox();
            this.TAT_combo_bx = new System.Windows.Forms.ComboBox();
            this.clear_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.req_sla_bx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AHT_s_bx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.calculate_btn = new System.Windows.Forms.Button();
            this.period_combo_bx = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(8, 216);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(81, 20);
            this.save_btn.TabIndex = 87;
            this.save_btn.Text = "Save CSV";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click_1);
            // 
            // select_btn
            // 
            this.select_btn.Location = new System.Drawing.Point(8, 217);
            this.select_btn.Name = "select_btn";
            this.select_btn.Size = new System.Drawing.Size(81, 20);
            this.select_btn.TabIndex = 86;
            this.select_btn.Text = "Select CSV";
            this.select_btn.UseVisualStyleBackColor = true;
            this.select_btn.Click += new System.EventHandler(this.select_btn_Click_1);
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(95, 217);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.ReadOnly = true;
            this.filePathTextBox.Size = new System.Drawing.Size(173, 20);
            this.filePathTextBox.TabIndex = 85;
            this.filePathTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(109, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 84;
            this.label11.Text = "Shrinkage (%)";
            // 
            // shrinkage_bx
            // 
            this.shrinkage_bx.Location = new System.Drawing.Point(187, 107);
            this.shrinkage_bx.Name = "shrinkage_bx";
            this.shrinkage_bx.Size = new System.Drawing.Size(81, 20);
            this.shrinkage_bx.TabIndex = 83;
            this.shrinkage_bx.Text = "90%";
            this.shrinkage_bx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TAT_combo_bx
            // 
            this.TAT_combo_bx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TAT_combo_bx.FormattingEnabled = true;
            this.TAT_combo_bx.Items.AddRange(new object[] {
            "0",
            "10",
            "20",
            "30",
            "40"});
            this.TAT_combo_bx.Location = new System.Drawing.Point(187, 78);
            this.TAT_combo_bx.MaxLength = 3;
            this.TAT_combo_bx.Name = "TAT_combo_bx";
            this.TAT_combo_bx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TAT_combo_bx.Size = new System.Drawing.Size(81, 21);
            this.TAT_combo_bx.TabIndex = 82;
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.SystemColors.Control;
            this.clear_btn.Location = new System.Drawing.Point(187, 281);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(81, 33);
            this.clear_btn.TabIndex = 80;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(274, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView1.Size = new System.Drawing.Size(785, 302);
            this.dataGridView1.TabIndex = 79;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 13);
            this.label7.TabIndex = 78;
            this.label7.Text = "Target Answer Time (Seconds)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 77;
            this.label6.Text = "Required SLA (%)";
            // 
            // req_sla_bx
            // 
            this.req_sla_bx.Location = new System.Drawing.Point(187, 163);
            this.req_sla_bx.Name = "req_sla_bx";
            this.req_sla_bx.Size = new System.Drawing.Size(81, 20);
            this.req_sla_bx.TabIndex = 76;
            this.req_sla_bx.Text = "90%";
            this.req_sla_bx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 13);
            this.label4.TabIndex = 75;
            this.label4.Text = "Average Handling Time (Seconds)";
            // 
            // AHT_s_bx
            // 
            this.AHT_s_bx.Location = new System.Drawing.Point(187, 135);
            this.AHT_s_bx.Name = "AHT_s_bx";
            this.AHT_s_bx.Size = new System.Drawing.Size(81, 20);
            this.AHT_s_bx.TabIndex = 74;
            this.AHT_s_bx.Text = "260";
            this.AHT_s_bx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 73;
            this.label3.Text = "Period In Minutes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 72;
            this.label1.Text = "Parameters";
            // 
            // calculate_btn
            // 
            this.calculate_btn.BackColor = System.Drawing.SystemColors.Control;
            this.calculate_btn.Location = new System.Drawing.Point(100, 281);
            this.calculate_btn.Name = "calculate_btn";
            this.calculate_btn.Size = new System.Drawing.Size(81, 33);
            this.calculate_btn.TabIndex = 71;
            this.calculate_btn.Text = "Calculate";
            this.calculate_btn.UseVisualStyleBackColor = false;
            this.calculate_btn.Click += new System.EventHandler(this.calculate_btn_Click_1);
            // 
            // period_combo_bx
            // 
            this.period_combo_bx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.period_combo_bx.FormattingEnabled = true;
            this.period_combo_bx.Items.AddRange(new object[] {
            "15",
            "30",
            "60"});
            this.period_combo_bx.Location = new System.Drawing.Point(187, 49);
            this.period_combo_bx.MaxLength = 3;
            this.period_combo_bx.Name = "period_combo_bx";
            this.period_combo_bx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.period_combo_bx.Size = new System.Drawing.Size(81, 21);
            this.period_combo_bx.TabIndex = 88;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(187, 191);
            this.dateTimePicker1.MaxDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(81, 20);
            this.dateTimePicker1.TabIndex = 89;
            this.dateTimePicker1.Value = new System.DateTime(2023, 3, 2, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 90;
            this.label2.Text = "Select Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(296, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 91;
            this.label5.Text = "Date: 03/03/2023";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1071, 348);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.period_combo_bx);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.select_btn);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.shrinkage_bx);
            this.Controls.Add(this.TAT_combo_bx);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.req_sla_bx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AHT_s_bx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculate_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Erlang Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button save_btn;
        private Button select_btn;
        private TextBox filePathTextBox;
        private Label label11;
        private TextBox shrinkage_bx;
        private ComboBox TAT_combo_bx;
        private Button clear_btn;
        private DataGridView dataGridView1;
        private Label label7;
        private Label label6;
        private TextBox req_sla_bx;
        private Label label4;
        private TextBox AHT_s_bx;
        private Label label3;
        private Label label1;
        private Button calculate_btn;
        private ComboBox period_combo_bx;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label5;
    }
}

