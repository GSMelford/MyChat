using MyChatClient.RequestsJSON;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyChatClient
{
    public partial class AuthorizationForm : Form
    {
        private bool AllowAuthorization = false;
        public RegistrationForm RegForm { get; }
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        public AuthorizationForm(RegistrationForm regForm)
        {
            InitializeComponent();
            RegForm = regForm;
            EmailOrPassword_textBox.Text = "fedorenko.max163@gmail.com";
            Password_textBox.Text = "228";
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            AllowAuthorization = CreateRequests.Authorization(EmailOrPassword_textBox.Text, Password_textBox.Text);
            if(AllowAuthorization)
            {
                ClientLogic.AllowMessenger = true;
                RegForm.Close();
            }
        }

        private void Registration_label_Click(object sender, EventArgs e)
        {
            RegForm.Show();
            this.Close();
        }
    }
}
