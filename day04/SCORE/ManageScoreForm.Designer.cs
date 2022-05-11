namespace day04
{
    partial class ManageScoreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageScoreForm));
            this.TextBoxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBoxCourse = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxScore = new System.Windows.Forms.TextBox();
            this.DataGridViewScore = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.btn_AddScore = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Average = new System.Windows.Forms.Button();
            this.btn_ShowStudent = new System.Windows.Forms.Button();
            this.btn_ShowScore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewScore)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxID
            // 
            this.TextBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxID.Location = new System.Drawing.Point(197, 68);
            this.TextBoxID.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxID.Name = "TextBoxID";
            this.TextBoxID.Size = new System.Drawing.Size(173, 22);
            this.TextBoxID.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(44, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Student ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select Course:";
            // 
            // ComboBoxCourse
            // 
            this.ComboBoxCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxCourse.FormattingEnabled = true;
            this.ComboBoxCourse.Location = new System.Drawing.Point(197, 115);
            this.ComboBoxCourse.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxCourse.Name = "ComboBoxCourse";
            this.ComboBoxCourse.Size = new System.Drawing.Size(286, 24);
            this.ComboBoxCourse.TabIndex = 8;
            this.ComboBoxCourse.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCourse_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(95, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Score:";
            // 
            // TextBoxScore
            // 
            this.TextBoxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxScore.Location = new System.Drawing.Point(197, 160);
            this.TextBoxScore.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxScore.Name = "TextBoxScore";
            this.TextBoxScore.Size = new System.Drawing.Size(110, 22);
            this.TextBoxScore.TabIndex = 10;
            // 
            // DataGridViewScore
            // 
            this.DataGridViewScore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewScore.BackgroundColor = System.Drawing.Color.Teal;
            this.DataGridViewScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewScore.Location = new System.Drawing.Point(606, 116);
            this.DataGridViewScore.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridViewScore.Name = "DataGridViewScore";
            this.DataGridViewScore.Size = new System.Drawing.Size(765, 490);
            this.DataGridViewScore.TabIndex = 11;
            this.DataGridViewScore.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewScore_CellClick);
            this.DataGridViewScore.Click += new System.EventHandler(this.DataGridViewScore_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(29, 210);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Description:";
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Location = new System.Drawing.Point(197, 212);
            this.TextBoxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(320, 116);
            this.TextBoxDescription.TabIndex = 13;
            // 
            // btn_AddScore
            // 
            this.btn_AddScore.BackColor = System.Drawing.Color.Green;
            this.btn_AddScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddScore.ForeColor = System.Drawing.Color.Snow;
            this.btn_AddScore.Location = new System.Drawing.Point(48, 378);
            this.btn_AddScore.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AddScore.Name = "btn_AddScore";
            this.btn_AddScore.Size = new System.Drawing.Size(192, 60);
            this.btn_AddScore.TabIndex = 69;
            this.btn_AddScore.Text = "Add";
            this.btn_AddScore.UseVisualStyleBackColor = false;
            this.btn_AddScore.Click += new System.EventHandler(this.btn_AddScore_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remove.ForeColor = System.Drawing.Color.Snow;
            this.btn_Remove.Location = new System.Drawing.Point(357, 369);
            this.btn_Remove.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(192, 60);
            this.btn_Remove.TabIndex = 70;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = false;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Average
            // 
            this.btn_Average.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Average.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Average.ForeColor = System.Drawing.Color.Snow;
            this.btn_Average.Location = new System.Drawing.Point(84, 472);
            this.btn_Average.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Average.Name = "btn_Average";
            this.btn_Average.Size = new System.Drawing.Size(465, 60);
            this.btn_Average.TabIndex = 71;
            this.btn_Average.Text = "Average Score By Course";
            this.btn_Average.UseVisualStyleBackColor = false;
            this.btn_Average.Click += new System.EventHandler(this.btn_Average_Click);
            // 
            // btn_ShowStudent
            // 
            this.btn_ShowStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_ShowStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ShowStudent.ForeColor = System.Drawing.Color.Snow;
            this.btn_ShowStudent.Location = new System.Drawing.Point(643, 31);
            this.btn_ShowStudent.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ShowStudent.Name = "btn_ShowStudent";
            this.btn_ShowStudent.Size = new System.Drawing.Size(242, 60);
            this.btn_ShowStudent.TabIndex = 72;
            this.btn_ShowStudent.Text = "Show Student";
            this.btn_ShowStudent.UseVisualStyleBackColor = false;
            this.btn_ShowStudent.Click += new System.EventHandler(this.btn_ShowStudent_Click);
            // 
            // btn_ShowScore
            // 
            this.btn_ShowScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_ShowScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ShowScore.ForeColor = System.Drawing.Color.Snow;
            this.btn_ShowScore.Location = new System.Drawing.Point(1076, 31);
            this.btn_ShowScore.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ShowScore.Name = "btn_ShowScore";
            this.btn_ShowScore.Size = new System.Drawing.Size(244, 60);
            this.btn_ShowScore.TabIndex = 73;
            this.btn_ShowScore.Text = "Show Score";
            this.btn_ShowScore.UseVisualStyleBackColor = false;
            this.btn_ShowScore.Click += new System.EventHandler(this.btn_ShowScore_Click);
            // 
            // ManageScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1400, 650);
            this.Controls.Add(this.btn_ShowScore);
            this.Controls.Add(this.btn_ShowStudent);
            this.Controls.Add(this.btn_Average);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_AddScore);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DataGridViewScore);
            this.Controls.Add(this.TextBoxScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComboBoxCourse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageScoreForm";
            this.Text = "ManageScoreForm";
            this.Load += new System.EventHandler(this.ManageScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBoxCourse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxScore;
        private System.Windows.Forms.DataGridView DataGridViewScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxDescription;
        private System.Windows.Forms.Button btn_AddScore;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Average;
        private System.Windows.Forms.Button btn_ShowStudent;
        private System.Windows.Forms.Button btn_ShowScore;
    }
}