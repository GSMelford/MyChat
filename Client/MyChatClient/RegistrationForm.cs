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

#if DEBUG
            UsernameBox.Text = "GSMelford";
            EmailBox.Text = "fedorenko.max163@gmail.com";
            PasswordBox.Text = "ig4ghd87T%@4gsif39";
#endif
            if (UsernameBox.Text == string.Empty)
            {
                MessageBox.Show("Поле с ник неймом должно быть заполнено.");
                return;
            }
            else if (EmailBox.Text == string.Empty)
            {
                MessageBox.Show("Поле с электроной почтой должно быть заполнено.");
                return;
            }
            else if (PasswordBox.Text == string.Empty)
            {
                MessageBox.Show("Поле с паролем должно быть заполнено. Придумайте сложный пароль, ведь это защита Вашего аккаунта.");
                return;
            }
            else if (PasswordBox.Text.Length < 8)
            {
                MessageBox.Show("Ваш пароль слишком маленький. Он должен содержать больше 8 символов. Это ради Вашей безопасности.");
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
                    MessageBox.Show("Вы ввели не адрес электройно почти.");
                    return;
                }
            }

            if(CreateRequests.Registration(UsernameBox.Text, EmailBox.Text, PasswordBox.Text))
            {
                MessageBox.Show($"На вашу почту: {EmailBox.Text} был отправлен код для подтверждения.");
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
            this.Hide();
            authorizationForm.ShowDialog();
            if(ClientLogic.Registered)
            {
                MessengerForm.Show();
                this.Close();
            }
        }
    }
}