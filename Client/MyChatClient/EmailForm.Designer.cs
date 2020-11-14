namespace MyChatClient
{
    partial class EmailForm
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
            this.SendEmail_button = new System.Windows.Forms.Button();
            this.CodeEmail_textBox = new System.Windows.Forms.TextBox();
            this.Email_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SendEmail_button
            // 
            this.SendEmail_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SendEmail_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SendEmail_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SendEmail_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.SendEmail_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendEmail_button.ForeColor = System.Drawing.Color.White;
            this.SendEmail_button.Location = new System.Drawing.Point(12, 76);
            this.SendEmail_button.Name = "SendEmail_button";
            this.SendEmail_button.Size = new System.Drawing.Size(250, 45);
            this.SendEmail_button.TabIndex = 0;
            this.SendEmail_button.Text = "Enter";
            this.SendEmail_button.UseVisualStyleBackColor = false;
            this.SendEmail_button.Click += new System.EventHandler(this.SendEmail_button_Click);
            // 
            // CodeEmail_textBox
            // 
            this.CodeEmail_textBox.Location = new System.Drawing.Point(61, 41);
            this.CodeEmail_textBox.Name = "CodeEmail_textBox";
            this.CodeEmail_textBox.Size = new System.Drawing.Size(151, 29);
            this.CodeEmail_textBox.TabIndex = 1;
            // 
            // Email_label
            // 
            this.Email_label.ForeColor = System.Drawing.Color.White;
            this.Email_label.Location = new System.Drawing.Point(12, 9);
            this.Email_label.Name = "Email_label";
            this.Email_label.Size = new System.Drawing.Size(250, 29);
            this.Email_label.TabIndex = 2;
            this.Email_label.Text = "Введите код подтверждения:";
            // 
            // EmailForm
            // 
            this.AcceptButton = this.SendEmail_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(273, 143);
            this.Controls.Add(this.Email_label);
            this.Controls.Add(this.CodeEmail_textBox);
            this.Controls.Add(this.SendEmail_button);
            this.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmailForm";
            this.Text = "EmailVerification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendEmail_button;
        private System.Windows.Forms.TextBox CodeEmail_textBox;
        private System.Windows.Forms.Label Email_label;
    }
}