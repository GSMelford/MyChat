using MyChatClient.RequestsJSON;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyChatClient
{
    public partial class AuthorizationForm : Form
    {
        public RegistrationForm RegistrationForm { get; }
        public bool RegistrationFormMain = false;
        public AuthorizationForm(RegistrationForm registrationForm)
        {
            InitializeComponent();
            RegistrationForm = registrationForm;
            PasswordBox.UseSystemPasswordChar = true;
#if DEBUG
            UsernameOrEmailBox.Text = "GSMelford";
            PasswordBox.Text = "ig4ghd87T%@4gsif39";
#endif
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UsernameOrEmailBox.Text == string.Empty)
            {
                MessageBox.Show("Поле с ник неймом и электроной почтой должно быть заполнено.");
                return;
            }
            else if (PasswordBox.Text == string.Empty)
            {
                MessageBox.Show("Поле с паролем должно быть заполнено. Придумайте сложный пароль, ведь это защита Вашего аккаунта.");
                return;
            }

            if(CreateRequests.Authorization(UsernameOrEmailBox.Text, PasswordBox.Text))
            {
                ClientLogic.Registered = true;
                this.Close();
            }
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked == false)
                PasswordBox.UseSystemPasswordChar = true;
            else
                PasswordBox.UseSystemPasswordChar = false;
        }
    }
}
