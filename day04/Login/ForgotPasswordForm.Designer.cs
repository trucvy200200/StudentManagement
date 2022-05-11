namespace day04
{
    partial class ForgotPasswordForm
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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Change = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxOTP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxConfirm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.btn_Change2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.Red;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.Snow;
            this.btn_Cancel.Location = new System.Drawing.Point(171, 249);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(127, 37);
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "CANCEL";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Change
            // 
            this.btn_Change.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Change.ForeColor = System.Drawing.Color.Snow;
            this.btn_Change.Location = new System.Drawing.Point(452, 26);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(127, 37);
            this.btn_Change.TabIndex = 10;
            this.btn_Change.Text = "Send Message";
            this.btn_Change.UseVisualStyleBackColor = false;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(213, 35);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(219, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(73, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Email: ";
            // 
            // TextBoxOTP
            // 
            this.TextBoxOTP.Location = new System.Drawing.Point(213, 88);
            this.TextBoxOTP.Name = "TextBoxOTP";
            this.TextBoxOTP.Size = new System.Drawing.Size(219, 20);
            this.TextBoxOTP.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(83, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Enter OTP: ";
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(213, 137);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.ReadOnly = true;
            this.textBoxPass.Size = new System.Drawing.Size(219, 20);
            this.textBoxPass.TabIndex = 15;
            this.textBoxPass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(41, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "New Password: ";
            // 
            // textBoxConfirm
            // 
            this.textBoxConfirm.Location = new System.Drawing.Point(213, 191);
            this.textBoxConfirm.Name = "textBoxConfirm";
            this.textBoxConfirm.ReadOnly = true;
            this.textBoxConfirm.Size = new System.Drawing.Size(219, 20);
            this.textBoxConfirm.TabIndex = 17;
            this.textBoxConfirm.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(9, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Confirm Password: ";
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirm.ForeColor = System.Drawing.Color.Snow;
            this.btn_Confirm.Location = new System.Drawing.Point(454, 76);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(127, 37);
            this.btn_Confirm.TabIndex = 19;
            this.btn_Confirm.Text = "Cofirm";
            this.btn_Confirm.UseVisualStyleBackColor = false;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // btn_Change2
            // 
            this.btn_Change2.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_Change2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Change2.ForeColor = System.Drawing.Color.Snow;
            this.btn_Change2.Location = new System.Drawing.Point(338, 249);
            this.btn_Change2.Name = "btn_Change2";
            this.btn_Change2.Size = new System.Drawing.Size(127, 37);
            this.btn_Change2.TabIndex = 20;
            this.btn_Change2.Text = "Change Password";
            this.btn_Change2.UseVisualStyleBackColor = false;
            this.btn_Change2.Click += new System.EventHandler(this.btn_Change2_Click);
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(595, 298);
            this.Controls.Add(this.btn_Change2);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.textBoxConfirm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxOTP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Name = "ForgotPasswordForm";
            this.Text = "ForgotPasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxOTP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxConfirm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Button btn_Change2;
    }
}