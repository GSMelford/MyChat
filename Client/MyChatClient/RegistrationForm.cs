using MyChatClient.RequestsJSON;
using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace MyChatClient
{
    public partial class RegistrationForm : Form
    {
        public MessengerForm MessengerForm { get; }
        public RegistrationForm(MessengerForm messengerForm)
        {
            InitializeComponent();
            PasswordBox.UseSystemPasswordChar = true;
            MessengerForm = messengerForm;
        }
        private void ShowPassword_textBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked == false)
                PasswordBox.UseSystemPasswordChar = true;
            else
                PasswordBox.UseSystemPasswordChar = false;
        }
        private void RegistrationButton_Click(object sender, EventArgs e)
        {

            if (UsernameBox.Text == string.Empty)
            {
                MessageBox.Show("Поле з нік нейм не може залишатися порожнім.");
                return;
            }
            else if (EmailBox.Text == string.Empty)
            {
                MessageBox.Show("Поле з електронним поштою повинно бути заповнене.");
                return;
            }
            else if (PasswordBox.Text == string.Empty)
            {
                MessageBox.Show("Поле з паролем повинно бути заповнене. Вигадайте важкий пароль, адже це захист Вашого аккаунта.");
                return;
            }
            else if (PasswordBox.Text.Length < 8)
            {
                MessageBox.Show("Ваш пароль занадто маленький. Він повинен містити більше 8 символів. Це заради Вашої безпеки.");
                return;
            }
            else
            {
                try
                {
                    var toAddress = new MailAddress(EmailBox.Text, "");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ви ввели не адреси електронним пошти.");
                    return;
                }
            }

            if(CreateRequests.Registration(UsernameBox.Text, EmailBox.Text, PasswordBox.Text))
            {
                MessageBox.Show($"На вашу пошту {EmailBox.Text} був відправлений код для підтвердження.");
                EmailForm emailForm = new EmailForm();
                emailForm.ShowDialog();
                if (ClientLogic.Registered)
                {
                    ClientLogic.Username = UsernameBox.Text;
                    ClientLogic.Email = EmailBox.Text;
                    ClientLogic.Password = PasswordBox.Text;
                    ClientDirectory.SaveAuthorization();
                    MessengerForm.Show();
                    this.Close();
                }
            }
        }
        private void RegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!ClientLogic.Registered)
                Environment.Exit(0);
        }
        private void LoginLabel_Click(object sender, EventArgs e)
        {
            AuthorizationForm authorizationForm = new AuthorizationForm(this);
            ClientLogic.Registered = false;
            Hide();
            authorizationForm.ShowDialog();
            if(ClientLogic.Registered)
            {
                MessengerForm.Show();
                Close();
            }
            Show();
        }
    }
}