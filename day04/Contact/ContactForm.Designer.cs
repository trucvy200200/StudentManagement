namespace day04
{
    partial class ContactForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_Refresh = new System.Windows.Forms.Label();
            this.lb_edit = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_SelectContact = new System.Windows.Forms.Button();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Show = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEnterGroupName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_AddGroup = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxIDGroup = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxSelectGroup = new System.Windows.Forms.ComboBox();
            this.textBoxEnterNewName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_EditGroup = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_RemoveGroup = new System.Windows.Forms.Button();
            this.comboBoxSelectGroup2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(944, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lb_Refresh);
            this.panel1.Controls.Add(this.lb_edit);
            this.panel1.Controls.Add(this.lb_name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-5, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 100);
            this.panel1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(265, 37);
            this.label7.TabIndex = 7;
            this.label7.Text = "Human Resource";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(869, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "|";
            // 
            // lb_Refresh
            // 
            this.lb_Refresh.AutoSize = true;
            this.lb_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Refresh.Location = new System.Drawing.Point(885, 57);
            this.lb_Refresh.Name = "lb_Refresh";
            this.lb_Refresh.Size = new System.Drawing.Size(52, 16);
            this.lb_Refresh.TabIndex = 5;
            this.lb_Refresh.Text = "Log out";
            this.lb_Refresh.Click += new System.EventHandler(this.lb_Refresh_Click);
            // 
            // lb_edit
            // 
            this.lb_edit.AutoSize = true;
            this.lb_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_edit.Location = new System.Drawing.Point(790, 57);
            this.lb_edit.Name = "lb_edit";
            this.lb_edit.Size = new System.Drawing.Size(76, 16);
            this.lb_edit.TabIndex = 4;
            this.lb_edit.Text = "Edit my info";
            this.lb_edit.Click += new System.EventHandler(this.lb_edit_Click);
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(821, 23);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(34, 13);
            this.lb_name.TabIndex = 3;
            this.lb_name.Text = "(abc )";
            this.lb_name.Click += new System.EventHandler(this.lb_name_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Contact";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(12, 178);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(112, 32);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(12, 234);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(112, 32);
            this.btn_Edit.TabIndex = 4;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btn_Remove);
            this.panel2.Controls.Add(this.btn_SelectContact);
            this.panel2.Controls.Add(this.textBoxContact);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(12, 318);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(494, 134);
            this.panel2.TabIndex = 5;
            // 
            // btn_Remove
            // 
            this.btn_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remove.Location = new System.Drawing.Point(12, 66);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(460, 49);
            this.btn_Remove.TabIndex = 6;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = false;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_SelectContact
            // 
            this.btn_SelectContact.BackColor = System.Drawing.Color.Red;
            this.btn_SelectContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SelectContact.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_SelectContact.Location = new System.Drawing.Point(350, 21);
            this.btn_SelectContact.Name = "btn_SelectContact";
            this.btn_SelectContact.Size = new System.Drawing.Size(101, 22);
            this.btn_SelectContact.TabIndex = 9;
            this.btn_SelectContact.Text = "Select Contact";
            this.btn_SelectContact.UseVisualStyleBackColor = false;
            this.btn_SelectContact.Click += new System.EventHandler(this.btn_SelectContact_Click);
            // 
            // textBoxContact
            // 
            this.textBoxContact.Location = new System.Drawing.Point(170, 23);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(146, 20);
            this.textBoxContact.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(49, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Enter Contact ID:";
            // 
            // btn_Show
            // 
            this.btn_Show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Show.Location = new System.Drawing.Point(12, 471);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(181, 56);
            this.btn_Show.TabIndex = 10;
            this.btn_Show.Text = "Show Full List";
            this.btn_Show.UseVisualStyleBackColor = false;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(734, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 31);
            this.label6.TabIndex = 12;
            this.label6.Text = "Group";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(45, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Enter Group Name:";
            // 
            // textBoxEnterGroupName
            // 
            this.textBoxEnterGroupName.Location = new System.Drawing.Point(180, 19);
            this.textBoxEnterGroupName.Name = "textBoxEnterGroupName";
            this.textBoxEnterGroupName.Size = new System.Drawing.Size(255, 20);
            this.textBoxEnterGroupName.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(192, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 31);
            this.label8.TabIndex = 15;
            this.label8.Text = "Contact";
            // 
            // btn_AddGroup
            // 
            this.btn_AddGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_AddGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddGroup.Location = new System.Drawing.Point(26, 96);
            this.btn_AddGroup.Name = "btn_AddGroup";
            this.btn_AddGroup.Size = new System.Drawing.Size(445, 43);
            this.btn_AddGroup.TabIndex = 16;
            this.btn_AddGroup.Text = "Add";
            this.btn_AddGroup.UseVisualStyleBackColor = false;
            this.btn_AddGroup.Click += new System.EventHandler(this.btn_AddGroup_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxIDGroup);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.btn_AddGroup);
            this.panel3.Controls.Add(this.textBoxEnterGroupName);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(542, 167);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(494, 162);
            this.panel3.TabIndex = 10;
            // 
            // textBoxIDGroup
            // 
            this.textBoxIDGroup.Location = new System.Drawing.Point(180, 58);
            this.textBoxIDGroup.Name = "textBoxIDGroup";
            this.textBoxIDGroup.Size = new System.Drawing.Size(255, 20);
            this.textBoxIDGroup.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(103, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 16);
            this.label12.TabIndex = 18;
            this.label12.Text = "ID Group:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.comboBoxSelectGroup);
            this.panel4.Controls.Add(this.textBoxEnterNewName);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.btn_EditGroup);
            this.panel4.Location = new System.Drawing.Point(542, 335);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(494, 173);
            this.panel4.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(68, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Select Group:";
            // 
            // comboBoxSelectGroup
            // 
            this.comboBoxSelectGroup.FormattingEnabled = true;
            this.comboBoxSelectGroup.Location = new System.Drawing.Point(180, 22);
            this.comboBoxSelectGroup.Name = "comboBoxSelectGroup";
            this.comboBoxSelectGroup.Size = new System.Drawing.Size(255, 21);
            this.comboBoxSelectGroup.TabIndex = 20;
            // 
            // textBoxEnterNewName
            // 
            this.textBoxEnterNewName.Location = new System.Drawing.Point(180, 77);
            this.textBoxEnterNewName.Name = "textBoxEnterNewName";
            this.textBoxEnterNewName.Size = new System.Drawing.Size(255, 20);
            this.textBoxEnterNewName.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(45, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Enter New Name:";
            // 
            // btn_EditGroup
            // 
            this.btn_EditGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_EditGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditGroup.Location = new System.Drawing.Point(26, 116);
            this.btn_EditGroup.Name = "btn_EditGroup";
            this.btn_EditGroup.Size = new System.Drawing.Size(445, 43);
            this.btn_EditGroup.TabIndex = 16;
            this.btn_EditGroup.Text = "Edit";
            this.btn_EditGroup.UseVisualStyleBackColor = false;
            this.btn_EditGroup.Click += new System.EventHandler(this.btn_EditGroup_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.btn_RemoveGroup);
            this.panel5.Controls.Add(this.comboBoxSelectGroup2);
            this.panel5.Location = new System.Drawing.Point(542, 535);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(494, 134);
            this.panel5.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(68, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "Select Group:";
            // 
            // btn_RemoveGroup
            // 
            this.btn_RemoveGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_RemoveGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RemoveGroup.Location = new System.Drawing.Point(26, 67);
            this.btn_RemoveGroup.Name = "btn_RemoveGroup";
            this.btn_RemoveGroup.Size = new System.Drawing.Size(445, 43);
            this.btn_RemoveGroup.TabIndex = 16;
            this.btn_RemoveGroup.Text = "Remove";
            this.btn_RemoveGroup.UseVisualStyleBackColor = false;
            this.btn_RemoveGroup.Click += new System.EventHandler(this.btn_RemoveGroup_Click);
            // 
            // comboBoxSelectGroup2
            // 
            this.comboBoxSelectGroup2.FormattingEnabled = true;
            this.comboBoxSelectGroup2.Location = new System.Drawing.Point(180, 25);
            this.comboBoxSelectGroup2.Name = "comboBoxSelectGroup2";
            this.comboBoxSelectGroup2.Size = new System.Drawing.Size(255, 21);
            this.comboBoxSelectGroup2.TabIndex = 22;
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1121, 697);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "ContactForm";
            this.Text = "ContactForm";
            this.Load += new System.EventHandler(this.ContactForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_Refresh;
        private System.Windows.Forms.Label lb_edit;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_SelectContact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Show;
        public System.Windows.Forms.TextBox textBoxContact;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEnterGroupName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_AddGroup;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxIDGroup;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxSelectGroup;
        private System.Windows.Forms.TextBox textBoxEnterNewName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_EditGroup;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_RemoveGroup;
        private System.Windows.Forms.ComboBox comboBoxSelectGroup2;
    }
}