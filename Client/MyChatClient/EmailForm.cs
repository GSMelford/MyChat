using MyChatClient.RequestsJSON;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
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
                    MessageBox.Show("Вы зарегистрировались. Поздравляем!");
                    RegForm.Show();
                    this.Close();
                }
                else
                {
                    CodeEmail_textBox.Clear();
                    MessageBox.Show("Некорректный ввод!");
                }
            }
        }
    }
}
