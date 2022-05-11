namespace day04
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Register = new System.Windows.Forms.Button();
            this.btn_ForgotPassWord = new System.Windows.Forms.Button();
            this.bt_Login = new System.Windows.Forms.Button();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(78, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(192, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Account Login";
            // 
            // btn_Register
            // 
            this.btn_Register.BackColor = System.Drawing.Color.Black;
            this.btn_Register.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Register.Location = new System.Drawing.Point(262, 247);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(174, 23);
            this.btn_Register.TabIndex = 17;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = false;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // btn_ForgotPassWord
            // 
            this.btn_ForgotPassWord.BackColor = System.Drawing.Color.Black;
            this.btn_ForgotPassWord.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ForgotPassWord.Location = new System.Drawing.Point(53, 247);
            this.btn_ForgotPassWord.Name = "btn_ForgotPassWord";
            this.btn_ForgotPassWord.Size = new System.Drawing.Size(174, 23);
            this.btn_ForgotPassWord.TabIndex = 16;
            this.btn_ForgotPassWord.Text = "Forgot Password?";
            this.btn_ForgotPassWord.UseVisualStyleBackColor = false;
            this.btn_ForgotPassWord.Click += new System.EventHandler(this.btn_ForgotPassWord_Click);
            // 
            // bt_Login
            // 
            this.bt_Login.BackColor = System.Drawing.Color.Green;
            this.bt_Login.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_Login.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Login.ForeColor = System.Drawing.Color.White;
            this.bt_Login.Location = new System.Drawing.Point(262, 288);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Size = new System.Drawing.Size(174, 67);
            this.bt_Login.TabIndex = 15;
            this.bt_Login.Text = "Login";
            this.bt_Login.UseVisualStyleBackColor = false;
            this.bt_Login.Click += new System.EventHandler(this.bt_Login_Click);
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.BackColor = System.Drawing.Color.Red;
            this.bt_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Cancel.ForeColor = System.Drawing.Color.White;
            this.bt_Cancel.Location = new System.Drawing.Point(53, 288);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(174, 67);
            this.bt_Cancel.TabIndex = 14;
            this.bt_Cancel.Text = "Cancel";
            this.bt_Cancel.UseVisualStyleBackColor = false;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(190, 195);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(215, 20);
            this.TextBoxPassword.TabIndex = 13;
            this.TextBoxPassword.UseSystemPasswordChar = true;
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.Location = new System.Drawing.Point(190, 143);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(215, 20);
            this.TextBoxUsername.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(48, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(35, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Username:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(474, 381);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.btn_ForgotPassWord);
            this.Controls.Add(this.bt_Login);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Button btn_ForgotPassWord;
        private System.Windows.Forms.Button bt_Login;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.TextBox TextBoxUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}