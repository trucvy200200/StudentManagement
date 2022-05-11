namespace day04
{
    partial class ManageCourses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCourses));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.listBoxCourse = new System.Windows.Forms.ListBox();
            this.TextBoxID = new System.Windows.Forms.TextBox();
            this.TextBoxLabel = new System.Windows.Forms.TextBox();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.NumericUpDownHours = new System.Windows.Forms.NumericUpDown();
            this.btn_First = new System.Windows.Forms.Button();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Last = new System.Windows.Forms.Button();
            this.LabelTotalCourses = new System.Windows.Forms.Label();
            this.comboBoxSemester = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownHours)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Label:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hours Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description:";
            // 
            // btn_Remove
            // 
            this.btn_Remove.BackColor = System.Drawing.Color.Crimson;
            this.btn_Remove.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remove.ForeColor = System.Drawing.Color.Snow;
            this.btn_Remove.Location = new System.Drawing.Point(308, 434);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(111, 46);
            this.btn_Remove.TabIndex = 52;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = false;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Add.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Add.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.Snow;
            this.btn_Add.Location = new System.Drawing.Point(11, 434);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(108, 46);
            this.btn_Add.TabIndex = 51;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.Green;
            this.btn_Edit.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.Color.Snow;
            this.btn_Edit.Location = new System.Drawing.Point(157, 434);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(108, 46);
            this.btn_Edit.TabIndex = 50;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // listBoxCourse
            // 
            this.listBoxCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCourse.FormattingEnabled = true;
            this.listBoxCourse.ItemHeight = 20;
            this.listBoxCourse.Location = new System.Drawing.Point(484, 38);
            this.listBoxCourse.Name = "listBoxCourse";
            this.listBoxCourse.Size = new System.Drawing.Size(365, 364);
            this.listBoxCourse.TabIndex = 53;
            this.listBoxCourse.Click += new System.EventHandler(this.listBoxCourse_Click);
            // 
            // TextBoxID
            // 
            this.TextBoxID.Location = new System.Drawing.Point(202, 24);
            this.TextBoxID.Multiline = true;
            this.TextBoxID.Name = "TextBoxID";
            this.TextBoxID.Size = new System.Drawing.Size(178, 26);
            this.TextBoxID.TabIndex = 54;
            // 
            // TextBoxLabel
            // 
            this.TextBoxLabel.Location = new System.Drawing.Point(202, 79);
            this.TextBoxLabel.Multiline = true;
            this.TextBoxLabel.Name = "TextBoxLabel";
            this.TextBoxLabel.Size = new System.Drawing.Size(178, 27);
            this.TextBoxLabel.TabIndex = 55;
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Location = new System.Drawing.Point(202, 196);
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(178, 96);
            this.TextBoxDescription.TabIndex = 57;
            // 
            // NumericUpDownHours
            // 
            this.NumericUpDownHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericUpDownHours.Location = new System.Drawing.Point(202, 134);
            this.NumericUpDownHours.Name = "NumericUpDownHours";
            this.NumericUpDownHours.Size = new System.Drawing.Size(178, 29);
            this.NumericUpDownHours.TabIndex = 58;
            // 
            // btn_First
            // 
            this.btn_First.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_First.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_First.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_First.ForeColor = System.Drawing.Color.Snow;
            this.btn_First.Location = new System.Drawing.Point(13, 360);
            this.btn_First.Name = "btn_First";
            this.btn_First.Size = new System.Drawing.Size(87, 46);
            this.btn_First.TabIndex = 59;
            this.btn_First.Text = "First";
            this.btn_First.UseVisualStyleBackColor = false;
            this.btn_First.Click += new System.EventHandler(this.btn_First_Click);
            // 
            // btn_Previous
            // 
            this.btn_Previous.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Previous.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Previous.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Previous.ForeColor = System.Drawing.Color.Snow;
            this.btn_Previous.Location = new System.Drawing.Point(119, 360);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(87, 46);
            this.btn_Previous.TabIndex = 60;
            this.btn_Previous.Text = "Previous";
            this.btn_Previous.UseVisualStyleBackColor = false;
            this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Next.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Next.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Next.ForeColor = System.Drawing.Color.Snow;
            this.btn_Next.Location = new System.Drawing.Point(226, 360);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(87, 46);
            this.btn_Next.TabIndex = 61;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = false;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Last
            // 
            this.btn_Last.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Last.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Last.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Last.ForeColor = System.Drawing.Color.Snow;
            this.btn_Last.Location = new System.Drawing.Point(332, 360);
            this.btn_Last.Name = "btn_Last";
            this.btn_Last.Size = new System.Drawing.Size(87, 46);
            this.btn_Last.TabIndex = 62;
            this.btn_Last.Text = "Last";
            this.btn_Last.UseVisualStyleBackColor = false;
            this.btn_Last.Click += new System.EventHandler(this.btn_Last_Click);
            // 
            // LabelTotalCourses
            // 
            this.LabelTotalCourses.AutoSize = true;
            this.LabelTotalCourses.BackColor = System.Drawing.Color.Fuchsia;
            this.LabelTotalCourses.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalCourses.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelTotalCourses.Location = new System.Drawing.Point(631, 434);
            this.LabelTotalCourses.Name = "LabelTotalCourses";
            this.LabelTotalCourses.Size = new System.Drawing.Size(209, 30);
            this.LabelTotalCourses.TabIndex = 63;
            this.LabelTotalCourses.Text = "Total Courses: ";
            // 
            // comboBoxSemester
            // 
            this.comboBoxSemester.FormattingEnabled = true;
            this.comboBoxSemester.Location = new System.Drawing.Point(202, 315);
            this.comboBoxSemester.Name = "comboBoxSemester";
            this.comboBoxSemester.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSemester.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(77, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 65;
            this.label5.Text = "Semester:";
            // 
            // ManageCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(905, 516);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxSemester);
            this.Controls.Add(this.LabelTotalCourses);
            this.Controls.Add(this.btn_Last);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Previous);
            this.Controls.Add(this.btn_First);
            this.Controls.Add(this.NumericUpDownHours);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.TextBoxLabel);
            this.Controls.Add(this.TextBoxID);
            this.Controls.Add(this.listBoxCourse);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManageCourses";
            this.Text = "ManageCourses";
            this.Load += new System.EventHandler(this.ManageCourses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.ListBox listBoxCourse;
        private System.Windows.Forms.TextBox TextBoxID;
        private System.Windows.Forms.TextBox TextBoxLabel;
        private System.Windows.Forms.TextBox TextBoxDescription;
        private System.Windows.Forms.NumericUpDown NumericUpDownHours;
        private System.Windows.Forms.Button btn_First;
        private System.Windows.Forms.Button btn_Previous;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Last;
        private System.Windows.Forms.Label LabelTotalCourses;
        private System.Windows.Forms.ComboBox comboBoxSemester;
        private System.Windows.Forms.Label label5;
    }
}