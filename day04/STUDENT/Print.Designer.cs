namespace day04
{
    partial class PrintForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintForm));
            this.wwwwwwwww = new System.Windows.Forms.Panel();
            this.btn_Check = new System.Windows.Forms.Button();
            this.radio_Female = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton_No = new System.Windows.Forms.RadioButton();
            this.radioButton_yes = new System.Windows.Forms.RadioButton();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radio_Male = new System.Windows.Forms.RadioButton();
            this.radio_All = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_Save = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.wwwwwwwww.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // wwwwwwwww
            // 
            this.wwwwwwwww.BackColor = System.Drawing.Color.Transparent;
            this.wwwwwwwww.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.wwwwwwwww.Controls.Add(this.btn_Check);
            this.wwwwwwwww.Controls.Add(this.radio_Female);
            this.wwwwwwwww.Controls.Add(this.panel2);
            this.wwwwwwwww.Controls.Add(this.radio_Male);
            this.wwwwwwwww.Controls.Add(this.radio_All);
            this.wwwwwwwww.Location = new System.Drawing.Point(53, 13);
            this.wwwwwwwww.Name = "wwwwwwwww";
            this.wwwwwwwww.Size = new System.Drawing.Size(808, 135);
            this.wwwwwwwww.TabIndex = 0;
            // 
            // btn_Check
            // 
            this.btn_Check.BackColor = System.Drawing.Color.Black;
            this.btn_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Check.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Check.Location = new System.Drawing.Point(700, 40);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(100, 49);
            this.btn_Check.TabIndex = 3;
            this.btn_Check.Text = "CHECK";
            this.btn_Check.UseVisualStyleBackColor = false;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // radio_Female
            // 
            this.radio_Female.AutoSize = true;
            this.radio_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_Female.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.radio_Female.Location = new System.Drawing.Point(162, 38);
            this.radio_Female.Name = "radio_Female";
            this.radio_Female.Size = new System.Drawing.Size(86, 24);
            this.radio_Female.TabIndex = 2;
            this.radio_Female.Text = "Female";
            this.radio_Female.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.radioButton_No);
            this.panel2.Controls.Add(this.radioButton_yes);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(271, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 100);
            this.panel2.TabIndex = 1;
            // 
            // radioButton_No
            // 
            this.radioButton_No.AutoSize = true;
            this.radioButton_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_No.ForeColor = System.Drawing.Color.White;
            this.radioButton_No.Location = new System.Drawing.Point(262, 16);
            this.radioButton_No.Name = "radioButton_No";
            this.radioButton_No.Size = new System.Drawing.Size(49, 24);
            this.radioButton_No.TabIndex = 5;
            this.radioButton_No.TabStop = true;
            this.radioButton_No.Text = "No";
            this.radioButton_No.UseVisualStyleBackColor = true;
            this.radioButton_No.CheckedChanged += new System.EventHandler(this.radioButton_No_CheckedChanged);
            // 
            // radioButton_yes
            // 
            this.radioButton_yes.AutoSize = true;
            this.radioButton_yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_yes.ForeColor = System.Drawing.Color.White;
            this.radioButton_yes.Location = new System.Drawing.Point(184, 16);
            this.radioButton_yes.Name = "radioButton_yes";
            this.radioButton_yes.Size = new System.Drawing.Size(58, 24);
            this.radioButton_yes.TabIndex = 4;
            this.radioButton_yes.TabStop = true;
            this.radioButton_yes.Text = "Yes";
            this.radioButton_yes.UseVisualStyleBackColor = true;
            this.radioButton_yes.CheckedChanged += new System.EventHandler(this.radioButton_yes_CheckedChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(322, 63);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(89, 20);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(270, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "And";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(174, 64);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(89, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "BirthDate between:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Use Date Range: ";
            // 
            // radio_Male
            // 
            this.radio_Male.AutoSize = true;
            this.radio_Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_Male.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.radio_Male.Location = new System.Drawing.Point(85, 38);
            this.radio_Male.Name = "radio_Male";
            this.radio_Male.Size = new System.Drawing.Size(65, 24);
            this.radio_Male.TabIndex = 1;
            this.radio_Male.Text = "Male";
            this.radio_Male.UseVisualStyleBackColor = true;
            // 
            // radio_All
            // 
            this.radio_All.AutoSize = true;
            this.radio_All.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_All.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.radio_All.Location = new System.Drawing.Point(26, 38);
            this.radio_All.Name = "radio_All";
            this.radio_All.Size = new System.Drawing.Size(47, 24);
            this.radio_All.TabIndex = 0;
            this.radio_All.Text = "All";
            this.radio_All.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.Location = new System.Drawing.Point(53, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(808, 290);
            this.dataGridView1.TabIndex = 1;
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.DarkCyan;
            this.button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.Location = new System.Drawing.Point(205, 496);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(212, 37);
            this.button_Save.TabIndex = 2;
            this.button_Save.Text = "Save To Text File";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Print.Location = new System.Drawing.Point(484, 496);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(212, 37);
            this.btn_Print.TabIndex = 3;
            this.btn_Print.Text = "To Printer";
            this.btn_Print.UseVisualStyleBackColor = false;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(936, 569);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.wwwwwwwww);
            this.Name = "PrintForm";
            this.Text = "Print";
            this.Load += new System.EventHandler(this.Print_Load);
            this.wwwwwwwww.ResumeLayout(false);
            this.wwwwwwwww.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel wwwwwwwww;
        private System.Windows.Forms.RadioButton radio_Female;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radio_Male;
        private System.Windows.Forms.RadioButton radio_All;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.RadioButton radioButton_No;
        private System.Windows.Forms.RadioButton radioButton_yes;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}