namespace MyChatClient
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.Email = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.ShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.Registration = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegistrationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RegistrationButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RegistrationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.RegistrationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.RegistrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrationButton.ForeColor = System.Drawing.Color.White;
            this.RegistrationButton.Location = new System.Drawing.Point(43, 257);
            this.RegistrationButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(320, 64);
            this.RegistrationButton.TabIndex = 5;
            this.RegistrationButton.Text = "Зареєструватися";
            this.RegistrationButton.UseVisualStyleBackColor = false;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // Email
            // 
            this.Email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Email.AutoSize = true;
            this.Email.ForeColor = System.Drawing.Color.White;
            this.Email.Location = new System.Drawing.Point(39, 117);
            this.Email.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(230, 22);
            this.Email.TabIndex = 1;
            this.Email.Text = "Введіть електронну пошта:";
            // 
            // Password
            // 
            this.Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Password.AutoSize = true;
            this.Password.ForeColor = System.Drawing.Color.White;
            this.Password.Location = new System.Drawing.Point(39, 183);
            this.Password.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(139, 22);
            this.Password.TabIndex = 2;
            this.Password.Text = "Введіть пароль:";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordBox.Location = new System.Drawing.Point(43, 209);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(214, 29);
            this.PasswordBox.TabIndex = 2;
            // 
            // EmailBox
            // 
            this.EmailBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmailBox.Location = new System.Drawing.Point(43, 143);
            this.EmailBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(320, 29);
            this.EmailBox.TabIndex = 1;
            // 
            // UsernameBox
            // 
            this.UsernameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsernameBox.Location = new System.Drawing.Point(43, 77);
            this.UsernameBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(320, 29);
            this.UsernameBox.TabIndex = 0;
            // 
            // Username
            // 
            this.Username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Username.AutoSize = true;
            this.Username.ForeColor = System.Drawing.Color.White;
            this.Username.Location = new System.Drawing.Point(39, 51);
            this.Username.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(146, 22);
            this.Username.TabIndex = 7;
            this.Username.Text = "Введіть нікнейм:";
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.ForeColor = System.Drawing.Color.White;
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(261, 211);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(103, 26);
            this.ShowPasswordCheckBox.TabIndex = 9;
            this.ShowPasswordCheckBox.Text = "показати";
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            this.ShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPassword_textBox_CheckedChanged);
            // 
            // Registration
            // 
            this.Registration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Registration.AutoSize = true;
            this.Registration.ForeColor = System.Drawing.Color.White;
            this.Registration.Location = new System.Drawing.Point(151, 10);
            this.Registration.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(96, 22);
            this.Registration.TabIndex = 10;
            this.Registration.Text = "Реєстрація";
            // 
            // LoginLabel
            // 
            this.LoginLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginLabel.Font = new System.Drawing.Font("Open Sans SemiBold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LoginLabel.Location = new System.Drawing.Point(63, 325);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(278, 17);
            this.LoginLabel.TabIndex = 11;
            this.LoginLabel.Text = "Я вже зареєстрований, хочу авторизуватися.";
            this.LoginLabel.Click += new System.EventHandler(this.LoginLabel_Click);
            // 
            // RegistrationForm
            // 
            this.AcceptButton = this.RegistrationButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(404, 357);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.Registration);
            this.Controls.Add(this.ShowPasswordCheckBox);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.RegistrationButton);
            this.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Реєстрація";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistrationForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.CheckBox ShowPasswordCheckBox;
        private System.Windows.Forms.Label Registration;
        private System.Windows.Forms.Label LoginLabel;
    }
}