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
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.Email = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.ConnectStatus = new System.Windows.Forms.Label();
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
            this.RegistrationButton.Location = new System.Drawing.Point(43, 300);
            this.RegistrationButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(320, 64);
            this.RegistrationButton.TabIndex = 5;
            this.RegistrationButton.Text = "Зарегистрироваться";
            this.RegistrationButton.UseVisualStyleBackColor = false;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // Email
            // 
            this.Email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Email.AutoSize = true;
            this.Email.ForeColor = System.Drawing.Color.White;
            this.Email.Location = new System.Drawing.Point(39, 160);
            this.Email.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(235, 22);
            this.Email.TabIndex = 1;
            this.Email.Text = "Введите электроною почта:";
            // 
            // Password
            // 
            this.Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Password.AutoSize = true;
            this.Password.ForeColor = System.Drawing.Color.White;
            this.Password.Location = new System.Drawing.Point(39, 226);
            this.Password.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(145, 22);
            this.Password.TabIndex = 2;
            this.Password.Text = "Введите пароль:";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordBox.Location = new System.Drawing.Point(43, 252);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(214, 29);
            this.PasswordBox.TabIndex = 2;
            // 
            // EmailBox
            // 
            this.EmailBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmailBox.Location = new System.Drawing.Point(43, 186);
            this.EmailBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(320, 29);
            this.EmailBox.TabIndex = 1;
            // 
            // ConnectStatus
            // 
            this.ConnectStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConnectStatus.AutoSize = true;
            this.ConnectStatus.ForeColor = System.Drawing.Color.White;
            this.ConnectStatus.Location = new System.Drawing.Point(9, 411);
            this.ConnectStatus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ConnectStatus.Name = "ConnectStatus";
            this.ConnectStatus.Size = new System.Drawing.Size(136, 22);
            this.ConnectStatus.TabIndex = 6;
            this.ConnectStatus.Text = "Подключение...";
            // 
            // UsernameBox
            // 
            this.UsernameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsernameBox.Location = new System.Drawing.Point(43, 120);
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
            this.Username.Location = new System.Drawing.Point(39, 94);
            this.Username.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(161, 22);
            this.Username.TabIndex = 7;
            this.Username.Text = "Ввидите никнейм:";
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.ForeColor = System.Drawing.Color.White;
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(261, 254);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(102, 26);
            this.ShowPasswordCheckBox.TabIndex = 9;
            this.ShowPasswordCheckBox.Text = "показать";
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            this.ShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPassword_textBox_CheckedChanged);
            // 
            // Registration
            // 
            this.Registration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Registration.AutoSize = true;
            this.Registration.ForeColor = System.Drawing.Color.White;
            this.Registration.Location = new System.Drawing.Point(143, 51);
            this.Registration.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(113, 22);
            this.Registration.TabIndex = 10;
            this.Registration.Text = "Регистрация";
            // 
            // LoginLabel
            // 
            this.LoginLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginLabel.Font = new System.Drawing.Font("Open Sans SemiBold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LoginLabel.Location = new System.Drawing.Point(63, 368);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(283, 17);
            this.LoginLabel.TabIndex = 11;
            this.LoginLabel.Text = "Я уже зарегистрирован, хочу авторизоваться.";
            this.LoginLabel.Click += new System.EventHandler(this.LoginLabel_Click);
            // 
            // RegistrationForm
            // 
            this.AcceptButton = this.RegistrationButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(404, 442);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.Registration);
            this.Controls.Add(this.ShowPasswordCheckBox);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.ConnectStatus);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.RegistrationButton);
            this.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
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
        private System.Windows.Forms.Label ConnectStatus;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.CheckBox ShowPasswordCheckBox;
        private System.Windows.Forms.Label Registration;
        private System.Windows.Forms.Label LoginLabel;
    }
}

