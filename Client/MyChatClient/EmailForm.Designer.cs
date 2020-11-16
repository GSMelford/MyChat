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
            this.SendEmailCodeButton = new System.Windows.Forms.Button();
            this.EmailCodeBox = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SendEmailCodeButton
            // 
            this.SendEmailCodeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SendEmailCodeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SendEmailCodeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SendEmailCodeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.SendEmailCodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendEmailCodeButton.ForeColor = System.Drawing.Color.White;
            this.SendEmailCodeButton.Location = new System.Drawing.Point(41, 155);
            this.SendEmailCodeButton.Name = "SendEmailCodeButton";
            this.SendEmailCodeButton.Size = new System.Drawing.Size(250, 45);
            this.SendEmailCodeButton.TabIndex = 1;
            this.SendEmailCodeButton.Text = "Подтвердить";
            this.SendEmailCodeButton.UseVisualStyleBackColor = false;
            this.SendEmailCodeButton.Click += new System.EventHandler(this.SendEmail_button_Click);
            // 
            // EmailCodeBox
            // 
            this.EmailCodeBox.Location = new System.Drawing.Point(90, 94);
            this.EmailCodeBox.MaxLength = 5;
            this.EmailCodeBox.Name = "EmailCodeBox";
            this.EmailCodeBox.Size = new System.Drawing.Size(151, 29);
            this.EmailCodeBox.TabIndex = 0;
            this.EmailCodeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Email
            // 
            this.Email.ForeColor = System.Drawing.Color.White;
            this.Email.Location = new System.Drawing.Point(41, 38);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(250, 29);
            this.Email.TabIndex = 2;
            this.Email.Text = "Введите код подтверждения:";
            // 
            // EmailForm
            // 
            this.AcceptButton = this.SendEmailCodeButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(340, 245);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.EmailCodeBox);
            this.Controls.Add(this.SendEmailCodeButton);
            this.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmailForm";
            this.Text = "Подтверждение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendEmailCodeButton;
        private System.Windows.Forms.TextBox EmailCodeBox;
        private System.Windows.Forms.Label Email;
    }
}