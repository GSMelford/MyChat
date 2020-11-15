using MyChatClient.RequestsJSON;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyChatClient
{
    public partial class EmailForm : Form
    {
        RegistrationForm RegForm;
        public EmailForm()
        {
            InitializeComponent();
        }

        public EmailForm(RegistrationForm registrationForm)
        {
            InitializeComponent();
            RegForm = registrationForm;
            RegForm.Hide();
        }

        private void SendEmail_button_Click(object sender, EventArgs e)
        {
            int number;
            if (!int.TryParse(CodeEmail_textBox.Text, out number))
            {
                MessageBox.Show("Некорректный ввод! Попробуйте ещё раз.");
                CodeEmail_textBox.Clear();
            }
            else
            {
                if (RegForm.RequestsEmailCode(number))
                {
                    AuthorizationForm authorizationForm = new AuthorizationForm(RegForm);
                    authorizationForm.Show();
                    this.Close();
                }
                else
                    CodeEmail_textBox.Clear();
            }
        }
    }
}
