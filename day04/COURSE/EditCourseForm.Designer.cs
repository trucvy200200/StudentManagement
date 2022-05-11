namespace day04
{
    partial class EditCourseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCourseForm));
            this.btn_Edit = new System.Windows.Forms.Button();
            this.Description = new System.Windows.Forms.TextBox();
            this.Label = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxCourse = new System.Windows.Forms.ComboBox();
            this.NumericUpDownHours = new System.Windows.Forms.NumericUpDown();
            this.comboBoxSemester = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownHours)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.Gold;
            this.btn_Edit.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(171, 354);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(471, 44);
            this.btn_Edit.TabIndex = 17;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(324, 189);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(312, 97);
            this.Description.TabIndex = 16;
            // 
            // Label
            // 
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(324, 83);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(176, 29);
            this.Label.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(149, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 27);
            this.label4.TabIndex = 12;
            this.label4.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(205, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 27);
            this.label3.TabIndex = 11;
            this.label3.Text = "Period:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(221, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Label:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(177, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "Course ID:";
            // 
            // ComboBoxCourse
            // 
            this.ComboBoxCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxCourse.FormattingEnabled = true;
            this.ComboBoxCourse.Location = new System.Drawing.Point(324, 30);
            this.ComboBoxCourse.Name = "ComboBoxCourse";
            this.ComboBoxCourse.Size = new System.Drawing.Size(176, 24);
            this.ComboBoxCourse.TabIndex = 18;
            this.ComboBoxCourse.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCourse_SelectedIndexChanged);
            // 
            // NumericUpDownHours
            // 
            this.NumericUpDownHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericUpDownHours.Location = new System.Drawing.Point(324, 139);
            this.NumericUpDownHours.Name = "NumericUpDownHours";
            this.NumericUpDownHours.Size = new System.Drawing.Size(176, 29);
            this.NumericUpDownHours.TabIndex = 19;
            this.NumericUpDownHours.ValueChanged += new System.EventHandler(this.NumericUpDownHours_ValueChanged);
            // 
            // comboBoxSemester
            // 
            this.comboBoxSemester.FormattingEnabled = true;
            this.comboBoxSemester.Location = new System.Drawing.Point(324, 308);
            this.comboBoxSemester.Name = "comboBoxSemester";
            this.comboBoxSemester.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSemester.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(178, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 27);
            this.label6.TabIndex = 22;
            this.label6.Text = "Semester:";
            // 
            // EditCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(811, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxSemester);
            this.Controls.Add(this.NumericUpDownHours);
            this.Controls.Add(this.ComboBoxCourse);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditCourseForm";
            this.Text = "EditCourse";
            this.Load += new System.EventHandler(this.EditCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.TextBox Label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBoxCourse;
        private System.Windows.Forms.NumericUpDown NumericUpDownHours;
        private System.Windows.Forms.ComboBox comboBoxSemester;
        private System.Windows.Forms.Label label6;
    }
}