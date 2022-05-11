namespace day04
{
    partial class RemoveScoreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveScoreForm));
            this.DataGridViewScore = new System.Windows.Forms.DataGridView();
            this.btn_RemoveScore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewScore)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewScore
            // 
            this.DataGridViewScore.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataGridViewScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewScore.Location = new System.Drawing.Point(50, 31);
            this.DataGridViewScore.Name = "DataGridViewScore";
            this.DataGridViewScore.Size = new System.Drawing.Size(707, 333);
            this.DataGridViewScore.TabIndex = 0;
            // 
            // btn_RemoveScore
            // 
            this.btn_RemoveScore.BackColor = System.Drawing.Color.Yellow;
            this.btn_RemoveScore.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RemoveScore.Location = new System.Drawing.Point(50, 386);
            this.btn_RemoveScore.Name = "btn_RemoveScore";
            this.btn_RemoveScore.Size = new System.Drawing.Size(182, 42);
            this.btn_RemoveScore.TabIndex = 1;
            this.btn_RemoveScore.Text = "Remove Score";
            this.btn_RemoveScore.UseVisualStyleBackColor = false;
            this.btn_RemoveScore.Click += new System.EventHandler(this.btn_RemoveScore_Click);
            // 
            // RemoveScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_RemoveScore);
            this.Controls.Add(this.DataGridViewScore);
            this.Name = "RemoveScoreForm";
            this.Text = "RemoveScoreForm";
            this.Load += new System.EventHandler(this.RemoveScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewScore;
        private System.Windows.Forms.Button btn_RemoveScore;
    }
}