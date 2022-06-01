namespace day04
{
    partial class PrintCourseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintCourseForm));
            this.btn_Print = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.n = new System.Windows.Forms.Panel();
            this.radioButton_none = new System.Windows.Forms.RadioButton();
            this.btn_Check = new System.Windows.Forms.Button();
            this.radioButton_ZA = new System.Windows.Forms.RadioButton();
            this.radioButton_AZ = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.n.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Print
            // 
            this.btn_Print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Print.Location = new System.Drawing.Point(509, 428);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(212, 37);
            this.btn_Print.TabIndex = 6;
            this.btn_Print.Text = "To Printer";
            this.btn_Print.UseVisualStyleBackColor = false;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.DarkCyan;
            this.button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.Location = new System.Drawing.Point(188, 428);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(212, 37);
            this.button_Save.TabIndex = 5;
            this.button_Save.Text = "Save To Text File";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.Location = new System.Drawing.Point(47, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(808, 289);
            this.dataGridView1.TabIndex = 4;
            // 
            // n
            // 
            this.n.BackColor = System.Drawing.Color.Transparent;
            this.n.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.n.Controls.Add(this.radioButton_none);
            this.n.Controls.Add(this.btn_Check);
            this.n.Controls.Add(this.radioButton_ZA);
            this.n.Controls.Add(this.radioButton_AZ);
            this.n.Controls.Add(this.label1);
            this.n.Location = new System.Drawing.Point(47, 12);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(808, 77);
            this.n.TabIndex = 7;
            // 
            // radioButton_none
            // 
            this.radioButton_none.AutoSize = true;
            this.radioButton_none.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_none.ForeColor = System.Drawing.Color.White;
            this.radioButton_none.Location = new System.Drawing.Point(291, 19);
            this.radioButton_none.Name = "radioButton_none";
            this.radioButton_none.Size = new System.Drawing.Size(69, 24);
            this.radioButton_none.TabIndex = 6;
            this.radioButton_none.TabStop = true;
            this.radioButton_none.Text = "None";
            this.radioButton_none.UseVisualStyleBackColor = true;
            // 
            // btn_Check
            // 
            this.btn_Check.BackColor = System.Drawing.Color.Black;
            this.btn_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Check.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Check.Location = new System.Drawing.Point(609, 12);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(115, 42);
            this.btn_Check.TabIndex = 3;
            this.btn_Check.Text = "CHECK";
            this.btn_Check.UseVisualStyleBackColor = false;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // radioButton_ZA
            // 
            this.radioButton_ZA.AutoSize = true;
            this.radioButton_ZA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_ZA.ForeColor = System.Drawing.Color.White;
            this.radioButton_ZA.Location = new System.Drawing.Point(479, 19);
            this.radioButton_ZA.Name = "radioButton_ZA";
            this.radioButton_ZA.Size = new System.Drawing.Size(56, 24);
            this.radioButton_ZA.TabIndex = 5;
            this.radioButton_ZA.TabStop = true;
            this.radioButton_ZA.Text = "Z-A";
            this.radioButton_ZA.UseVisualStyleBackColor = true;
            // 
            // radioButton_AZ
            // 
            this.radioButton_AZ.AutoSize = true;
            this.radioButton_AZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_AZ.ForeColor = System.Drawing.Color.White;
            this.radioButton_AZ.Location = new System.Drawing.Point(386, 19);
            this.radioButton_AZ.Name = "radioButton_AZ";
            this.radioButton_AZ.Size = new System.Drawing.Size(56, 24);
            this.radioButton_AZ.TabIndex = 4;
            this.radioButton_AZ.TabStop = true;
            this.radioButton_AZ.Text = "A-Z";
            this.radioButton_AZ.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(160, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sort by name: ";
            // 
            // PrintCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(901, 486);
            this.Controls.Add(this.n);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PrintCourseForm";
            this.Text = "PrintCourseForm";
            this.Load += new System.EventHandler(this.PrintCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.n.ResumeLayout(false);
            this.n.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel n;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.RadioButton radioButton_ZA;
        private System.Windows.Forms.RadioButton radioButton_AZ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_none;
    }
}