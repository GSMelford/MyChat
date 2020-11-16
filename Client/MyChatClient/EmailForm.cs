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
        public EmailForm()
        {
            InitializeComponent();
        }

        private void SendEmail_button_Click(object sender, EventArgs e)
        {
            int code;
            if (!int.TryParse(EmailCodeBox.Text, out code))
            {
                MessageBox.Show("Некорректный ввод! Попробуйте ещё раз.");
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
