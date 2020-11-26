namespace MyChatClient
{
    partial class AuthorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.UsernameOrEmailBox = new System.Windows.Forms.TextBox();
            this.UsernameOrEmail = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Label();
            this.ShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.Registration = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(32, 156);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(235, 29);
            this.PasswordBox.TabIndex = 1;
            // 
            // UsernameOrEmailBox
            // 
            this.UsernameOrEmailBox.Location = new System.Drawing.Point(32, 99);
            this.UsernameOrEmailBox.Name = "UsernameOrEmailBox";
            this.UsernameOrEmailBox.Size = new System.Drawing.Size(343, 29);
            this.UsernameOrEmailBox.TabIndex = 0;
            // 
            // UsernameOrEmail
            // 
            this.UsernameOrEmail.AutoSize = true;
            this.UsernameOrEmail.ForeColor = System.Drawing.Color.White;
            this.UsernameOrEmail.Location = new System.Drawing.Point(28, 74);
            this.UsernameOrEmail.Name = "UsernameOrEmail";
            this.UsernameOrEmail.Size = new System.Drawing.Size(333, 22);
            this.UsernameOrEmail.TabIndex = 2;
            this.UsernameOrEmail.Text = "Введіть електронну пошту або нікнейм:";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.ForeColor = System.Drawing.Color.White;
            this.Password.Location = new System.Drawing.Point(29, 131);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(139, 22);
            this.Password.TabIndex = 3;
            this.Password.Text = "Введіть пароль:";
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.ForeColor = System.Drawing.Color.White;
            this.Login.Location = new System.Drawing.Point(125, 32);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(143, 22);
            this.Login.TabIndex = 4;
            this.Login.Text = "Авторизуватись";
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.ForeColor = System.Drawing.Color.White;
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(273, 159);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(103, 26);
            this.ShowPasswordCheckBox.TabIndex = 6;
            this.ShowPasswordCheckBox.Text = "показати";
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            this.ShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoginButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(32, 200);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(343, 64);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Авторизуватись";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // Registration
            // 
            this.Registration.AutoSize = true;
            this.Registration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Registration.Font = new System.Drawing.Font("Open Sans SemiBold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registration.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Registration.Location = new System.Drawing.Point(155, 271);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(94, 17);
            this.Registration.TabIndex = 12;
            this.Registration.Text = "Реєструватися";
            this.Registration.Click += new System.EventHandler(this.Registration_Click);
            // 
            // AuthorizationForm
            // 
            this.AcceptButton = this.LoginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(404, 310);
            this.Controls.Add(this.Registration);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.ShowPasswordCheckBox);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UsernameOrEmail);
            this.Controls.Add(this.UsernameOrEmailBox);
            this.Controls.Add(this.PasswordBox);
            this.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизація";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox UsernameOrEmailBox;
        private System.Windows.Forms.Label UsernameOrEmail;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.CheckBox ShowPasswordCheckBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label Registration;
    }
}