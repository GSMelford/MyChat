using MyChatClient.RequestsJSON;
using System;
using System.Windows.Forms;

namespace MyChatClient
{
    public partial class EmailForm : Form
    {
        public EmailForm()
        {
            InitializeComponent();
        }
        private void SendEmail_button_Click(object sender, EventArgs e)
        {
            int code;
            if (!int.TryParse(EmailCodeBox.Text, out code))
            {
                MessageBox.Show("Некоректне введення! Спробуйте ще раз.");
                EmailCodeBox.Clear();
            }
            else
            {
                if(CreateRequests.EmailConfirmation(code))
                {
                    ClientLogic.Registered = true;
                    this.Close();
                }
            }
        }
    }
}
