using MyChatClient.RequestsJSON;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyChatClient
{
    public partial class RegistrationForm : Form
    {
        private string authorization_catalog = @"AuthorizationSave";
        private string authorization_path = @"AuthorizationSave\AuthorizationSave.txt";
        bool AllowRegistration = false;
        public int EmailCode;
        ClientLogic Client;
        CreateRequests CreateRequests;

        public RegistrationForm()
        {
            InitializeComponent();

            if(!Directory.Exists(authorization_catalog))  // Если нету каталога авторизации создает его, в дальнейшем там храниться сейв с данными пользователя
                Directory.CreateDirectory(authorization_catalog);
            Password_textBox.UseSystemPasswordChar = true;
            if (ClientLogic.ServerConnection())
            {
                ConnectStatus_label.Text = "Клиент подключен к серверу.";
            }
            else
            {
                ConnectStatus_label.Text = "Подключение к серверу отсутствует.";
            }
        }
        private void Login_button_Click(object sender, EventArgs e)
        {
            Client = new ClientLogic(Username_textBox.Text, Email_textBox.Text, Password_textBox.Text);
            CreateRequests = new CreateRequests(Client);
            AllowRegistration = CreateRequests.Registration();
            if (AllowRegistration)
            {
                EmailForm emailForm = new EmailForm(this);
                emailForm.Show();
            }
        }
        public bool RequestsEmailCode(int code) => CreateRequests.EmailCheack(code);
        private void ShowPassword_textBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword_textBox.Checked == false)
                Password_textBox.UseSystemPasswordChar = true;
            else
                Password_textBox.UseSystemPasswordChar = false;
        }
    }
}