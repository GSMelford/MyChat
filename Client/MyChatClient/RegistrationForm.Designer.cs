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
            this.Login_button = new System.Windows.Forms.Button();
            this.Email_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.Email_textBox = new System.Windows.Forms.TextBox();
            this.ConnectStatus_label = new System.Windows.Forms.Label();
            this.Username_textBox = new System.Windows.Forms.TextBox();
            this.Username_label = new System.Windows.Forms.Label();
            this.ShowPassword_textBox = new System.Windows.Forms.CheckBox();
            this.Registration_label = new System.Windows.Forms.Label();
            this.Login_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Login_button
            // 
            this.Login_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Login_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Login_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Login_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_button.ForeColor = System.Drawing.Color.White;
            this.Login_button.Location = new System.Drawing.Point(43, 300);
            this.Login_button.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(320, 64);
            this.Login_button.TabIndex = 5;
            this.Login_button.Text = "Зарегистрироваться";
            this.Login_button.UseVisualStyleBackColor = false;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // Email_label
            // 
            this.Email_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Email_label.AutoSize = true;
            this.Email_label.ForeColor = System.Drawing.Color.White;
            this.Email_label.Location = new System.Drawing.Point(39, 160);
            this.Email_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Email_label.Name = "Email_label";
            this.Email_label.Size = new System.Drawing.Size(235, 22);
            this.Email_label.TabIndex = 1;
            this.Email_label.Text = "Введите электроною почта:";
            // 
            // Password_label
            // 
            this.Password_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Password_label.AutoSize = true;
            this.Password_label.ForeColor = System.Drawing.Color.White;
            this.Password_label.Location = new System.Drawing.Point(39, 226);
            this.Password_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(145, 22);
            this.Password_label.TabIndex = 2;
            this.Password_label.Text = "Введите пароль:";
            // 
            // Password_textBox
            // 
            this.Password_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Password_textBox.Location = new System.Drawing.Point(43, 252);
            this.Password_textBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.Size = new System.Drawing.Size(214, 29);
            this.Password_textBox.TabIndex = 2;
            // 
            // Email_textBox
            // 
            this.Email_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Email_textBox.Location = new System.Drawing.Point(43, 186);
            this.Email_textBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Email_textBox.Name = "Email_textBox";
            this.Email_textBox.Size = new System.Drawing.Size(320, 29);
            this.Email_textBox.TabIndex = 1;
            // 
            // ConnectStatus_label
            // 
            this.ConnectStatus_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConnectStatus_label.AutoSize = true;
            this.ConnectStatus_label.ForeColor = System.Drawing.Color.White;
            this.ConnectStatus_label.Location = new System.Drawing.Point(9, 411);
            this.ConnectStatus_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ConnectStatus_label.Name = "ConnectStatus_label";
            this.ConnectStatus_label.Size = new System.Drawing.Size(136, 22);
            this.ConnectStatus_label.TabIndex = 6;
            this.ConnectStatus_label.Text = "Подключение...";
            // 
            // Username_textBox
            // 
            this.Username_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Username_textBox.Location = new System.Drawing.Point(43, 120);
            this.Username_textBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Username_textBox.Name = "Username_textBox";
            this.Username_textBox.Size = new System.Drawing.Size(320, 29);
            this.Username_textBox.TabIndex = 0;
            // 
            // Username_label
            // 
            this.Username_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Username_label.AutoSize = true;
            this.Username_label.ForeColor = System.Drawing.Color.White;
            this.Username_label.Location = new System.Drawing.Point(39, 94);
            this.Username_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Username_label.Name = "Username_label";
            this.Username_label.Size = new System.Drawing.Size(161, 22);
            this.Username_label.TabIndex = 7;
            this.Username_label.Text = "Ввидите никнейм:";
            // 
            // ShowPassword_textBox
            // 
            this.ShowPassword_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ShowPassword_textBox.AutoSize = true;
            this.ShowPassword_textBox.ForeColor = System.Drawing.Color.White;
            this.ShowPassword_textBox.Location = new System.Drawing.Point(261, 254);
            this.ShowPassword_textBox.Name = "ShowPassword_textBox";
            this.ShowPassword_textBox.Size = new System.Drawing.Size(102, 26);
            this.ShowPassword_textBox.TabIndex = 9;
            this.ShowPassword_textBox.Text = "показать";
            this.ShowPassword_textBox.UseVisualStyleBackColor = true;
            this.ShowPassword_textBox.CheckedChanged += new System.EventHandler(this.ShowPassword_textBox_CheckedChanged);
            // 
            // Registration_label
            // 
            this.Registration_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Registration_label.AutoSize = true;
            this.Registration_label.ForeColor = System.Drawing.Color.White;
            this.Registration_label.Location = new System.Drawing.Point(143, 51);
            this.Registration_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Registration_label.Name = "Registration_label";
            this.Registration_label.Size = new System.Drawing.Size(113, 22);
            this.Registration_label.TabIndex = 10;
            this.Registration_label.Text = "Регистрация";
            // 
            // Login_label
            // 
            this.Login_label.AutoSize = true;
            this.Login_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_label.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Login_label.Location = new System.Drawing.Point(9, 368);
            this.Login_label.Name = "Login_label";
            this.Login_label.Size = new System.Drawing.Size(383, 22);
            this.Login_label.TabIndex = 11;
            this.Login_label.Text = "Я уже зарегистрирован, хочу авторизоваться.";
            this.Login_label.Click += new System.EventHandler(this.Login_label_Click);
            // 
            // RegistrationForm
            // 
            this.AcceptButton = this.Login_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(404, 442);
            this.Controls.Add(this.Login_label);
            this.Controls.Add(this.Registration_label);
            this.Controls.Add(this.ShowPassword_textBox);
            this.Controls.Add(this.Username_textBox);
            this.Controls.Add(this.Username_label);
            this.Controls.Add(this.ConnectStatus_label);
            this.Controls.Add(this.Email_textBox);
            this.Controls.Add(this.Password_textBox);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.Email_label);
            this.Controls.Add(this.Login_button);
            this.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Label Email_label;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.TextBox Email_textBox;
        private System.Windows.Forms.Label ConnectStatus_label;
        private System.Windows.Forms.TextBox Username_textBox;
        private System.Windows.Forms.Label Username_label;
        private System.Windows.Forms.CheckBox ShowPassword_textBox;
        private System.Windows.Forms.Label Registration_label;
        private System.Windows.Forms.Label Login_label;
    }
}

