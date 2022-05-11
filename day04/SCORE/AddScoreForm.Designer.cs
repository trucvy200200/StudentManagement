namespace day04
{
    partial class AddScoreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddScoreForm));
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.TextBoxScore = new System.Windows.Forms.TextBox();
            this.TextBoxID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
            this.btn_AddScore = new System.Windows.Forms.Button();
            this.ComboBoxCourse = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Location = new System.Drawing.Point(186, 208);
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(206, 104);
            this.TextBoxDescription.TabIndex = 65;
            // 
            // TextBoxScore
            // 
            this.TextBoxScore.Location = new System.Drawing.Point(186, 155);
            this.TextBoxScore.Multiline = true;
            this.TextBoxScore.Name = "TextBoxScore";
            this.TextBoxScore.Size = new System.Drawing.Size(206, 27);
            this.TextBoxScore.TabIndex = 64;
            // 
            // TextBoxID
            // 
            this.TextBoxID.Location = new System.Drawing.Point(186, 56);
            this.TextBoxID.Multiline = true;
            this.TextBoxID.Name = "TextBoxID";
            this.TextBoxID.Size = new System.Drawing.Size(206, 26);
            this.TextBoxID.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 23);
            this.label4.TabIndex = 62;
            this.label4.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 61;
            this.label3.Text = "Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 23);
            this.label2.TabIndex = 60;
            this.label2.Text = "Select Course:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 59;
            this.label1.Text = "Student ID:";
            // 
            // dataGridViewStudent
            // 
            this.dataGridViewStudent.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudent.Location = new System.Drawing.Point(425, 33);
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            this.dataGridViewStudent.Size = new System.Drawing.Size(332, 348);
            this.dataGridViewStudent.TabIndex = 67;
            this.dataGridViewStudent.Click += new System.EventHandler(this.dataGridViewStudent_Click);
            // 
            // btn_AddScore
            // 
            this.btn_AddScore.BackColor = System.Drawing.Color.Green;
            this.btn_AddScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddScore.ForeColor = System.Drawing.Color.Snow;
            this.btn_AddScore.Location = new System.Drawing.Point(195, 335);
            this.btn_AddScore.Name = "btn_AddScore";
            this.btn_AddScore.Size = new System.Drawing.Size(168, 46);
            this.btn_AddScore.TabIndex = 68;
            this.btn_AddScore.Text = "Add Score";
            this.btn_AddScore.UseVisualStyleBackColor = false;
            this.btn_AddScore.Click += new System.EventHandler(this.btn_AddScore_Click);
            // 
            // ComboBoxCourse
            // 
            this.ComboBoxCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxCourse.FormattingEnabled = true;
            this.ComboBoxCourse.Location = new System.Drawing.Point(186, 108);
            this.ComboBoxCourse.Name = "ComboBoxCourse";
            this.ComboBoxCourse.Size = new System.Drawing.Size(206, 28);
            this.ComboBoxCourse.TabIndex = 69;
            this.ComboBoxCourse.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCourse_SelectedIndexChanged);
            // 
            // AddScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ComboBoxCourse);
            this.Controls.Add(this.btn_AddScore);
            this.Controls.Add(this.dataGridViewStudent);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.TextBoxScore);
            this.Controls.Add(this.TextBoxID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddScoreForm";
            this.Text = "AddScoreForm";
            this.Load += new System.EventHandler(this.AddScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextBoxDescription;
        private System.Windows.Forms.TextBox TextBoxScore;
        private System.Windows.Forms.TextBox TextBoxID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewStudent;
        private System.Windows.Forms.Button btn_AddScore;
        private System.Windows.Forms.ComboBox ComboBoxCourse;
    }
}