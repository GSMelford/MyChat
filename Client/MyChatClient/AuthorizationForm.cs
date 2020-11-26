using MyChatClient.RequestsJSON;
using System;
using System.Windows.Forms;

namespace MyChatClient
{
    public partial class AuthorizationForm : Form
    {
        public RegistrationForm registrationForm { get; }
        public AuthorizationForm(RegistrationForm registrationForm)
        {
            InitializeComponent();
            this.registrationForm = registrationForm;
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
                MessageBox.Show("Поле з нік нейм і електронною поштою не може залишатися порожнім.");
                return;
            }
            else if (PasswordBox.Text == string.Empty)
            {
                MessageBox.Show("Поле з паролем повинно бути заповнене. Вигадайте важкий пароль, адже це захист Вашого аккаунта.");
                return;
            }

            if(CreateRequests.Authorization(UsernameOrEmailBox.Text, PasswordBox.Text))
            {
                ClientLogic.Registered = true;
                Close();
            }
        }
        private void Registration_Click(object sender, EventArgs e)
        {
            registrationForm.Hide();
            Close();
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
