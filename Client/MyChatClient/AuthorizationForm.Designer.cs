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
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.EmailOrPassword_textBox = new System.Windows.Forms.TextBox();
            this.UsernameOrEmail_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.Login_label = new System.Windows.Forms.Label();
            this.ShowPassword_checkBoz = new System.Windows.Forms.CheckBox();
            this.Login_button = new System.Windows.Forms.Button();
            this.Registration_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Password_textBox
            // 
            this.Password_textBox.Location = new System.Drawing.Point(32, 156);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.Size = new System.Drawing.Size(210, 29);
            this.Password_textBox.TabIndex = 0;
            // 
            // EmailOrPassword_textBox
            // 
            this.EmailOrPassword_textBox.Location = new System.Drawing.Point(32, 99);
            this.EmailOrPassword_textBox.Name = "EmailOrPassword_textBox";
            this.EmailOrPassword_textBox.Size = new System.Drawing.Size(320, 29);
            this.EmailOrPassword_textBox.TabIndex = 1;
            // 
            // UsernameOrEmail_label
            // 
            this.UsernameOrEmail_label.AutoSize = true;
            this.UsernameOrEmail_label.Location = new System.Drawing.Point(28, 74);
            this.UsernameOrEmail_label.Name = "UsernameOrEmail_label";
            this.UsernameOrEmail_label.Size = new System.Drawing.Size(347, 22);
            this.UsernameOrEmail_label.TabIndex = 2;
            this.UsernameOrEmail_label.Text = "Введите электроную почту или никнейм:";
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Location = new System.Drawing.Point(29, 131);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(145, 22);
            this.Password_label.TabIndex = 3;
            this.Password_label.Text = "Введите пароль:";
            // 
            // Login_label
            // 
            this.Login_label.AutoSize = true;
            this.Login_label.Location = new System.Drawing.Point(125, 32);
            this.Login_label.Name = "Login_label";
            this.Login_label.Size = new System.Drawing.Size(142, 22);
            this.Login_label.TabIndex = 4;
            this.Login_label.Text = "Авторизоваться";
            // 
            // ShowPassword_checkBoz
            // 
            this.ShowPassword_checkBoz.AutoSize = true;
            this.ShowPassword_checkBoz.Location = new System.Drawing.Point(250, 158);
            this.ShowPassword_checkBoz.Name = "ShowPassword_checkBoz";
            this.ShowPassword_checkBoz.Size = new System.Drawing.Size(102, 26);
            this.ShowPassword_checkBoz.TabIndex = 6;
            this.ShowPassword_checkBoz.Text = "показать";
            this.ShowPassword_checkBoz.UseVisualStyleBackColor = true;
            // 
            // Login_button
            // 
            this.Login_button.Location = new System.Drawing.Point(32, 191);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(320, 64);
            this.Login_button.TabIndex = 7;
            this.Login_button.Text = "Авторизоваться";
            this.Login_button.UseVisualStyleBackColor = true;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // Registration_label
            // 
            this.Registration_label.AutoSize = true;
            this.Registration_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Registration_label.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registration_label.ForeColor = System.Drawing.Color.Blue;
            this.Registration_label.Location = new System.Drawing.Point(9, 274);
            this.Registration_label.Name = "Registration_label";
            this.Registration_label.Size = new System.Drawing.Size(383, 22);
            this.Registration_label.TabIndex = 12;
            this.Registration_label.Text = "Я уже зарегистрирован, хочу авторизоваться.";
            this.Registration_label.Click += new System.EventHandler(this.Registration_label_Click);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 330);
            this.Controls.Add(this.Registration_label);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.ShowPassword_checkBoz);
            this.Controls.Add(this.Login_label);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.UsernameOrEmail_label);
            this.Controls.Add(this.EmailOrPassword_textBox);
            this.Controls.Add(this.Password_textBox);
            this.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AuthorizationForm";
            this.Text = "AuthorizationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.TextBox EmailOrPassword_textBox;
        private System.Windows.Forms.Label UsernameOrEmail_label;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.Label Login_label;
        private System.Windows.Forms.CheckBox ShowPassword_checkBoz;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Label Registration_label;
    }
}