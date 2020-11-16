using MyChatClient.RequestsJSON;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyChatClient
{
    public partial class MessengerForm : Form
    {
        private int CounterFButton = 0;
        public MessengerForm()
        {
            InitializeComponent();
            if (!ClientLogic.ConnectToServer())
            {
                MessageBox.Show("Подключение к серверу отсутствует.");
                Environment.Exit(0);
            }

            if (ClientDirectory.LocalAuthorization())
            {
                ClientLogic.Registered = true;
                if(!CreateRequests.Authorization(ClientLogic.Email, ClientLogic.Password))
                {
                    RegistrationForm registrationForm = new RegistrationForm(this);
                    this.Hide();
                    registrationForm.ShowDialog();
                }
            }
            else
            {
                RegistrationForm registrationForm = new RegistrationForm(this);
                this.Hide();
                registrationForm.ShowDialog();
            }
            UsernameLable.Text = ClientLogic.Username;
            ClientLogic.messengerForm = this;
            Task receive = new Task(()=> { ClientLogic.GetServerAnswer();});
            receive.Start();
        }
        private void FriendButton_Click(object sender, EventArgs e)
        {
            string FriendUsername = (sender as Button).Tag.ToString();
            ClientLogic.FriendUserNow = FriendUsername;
            ChatMessageBox.Text = CreateRequests.GetChat(FriendUsername);
            FriendUsernameLable.Text = FriendUsername;
            SendButton.Enabled = true;
            SendMessageBox.Enabled = true;
        }
        public void RefreshFriendsToList(List<string> FriendListServer)
        {
            CounterFButton = 0;
            foreach (var button in ClientLogic.FriendList)
            {
                FriendListContainer.Controls.Remove(button);
            }
            foreach (var button in FriendListServer)
            {
                Button FriendButton = new Button();
                FriendButton.Location = new Point(0, CounterFButton);
                FriendButton.Width = 180;
                FriendButton.Height = 32;
                CounterFButton += 32;
                FriendButton.Tag = button;
                FriendButton.Text = button;
                ClientLogic.FriendList.Add(FriendButton);
                FriendListContainer.Controls.Add(FriendButton);
                FriendButton.Click += new System.EventHandler(this.FriendButton_Click);
            }
        }
        private void MessengerForm_Load(object sender, EventArgs e)
        {
            RefreshFriendsToList(CreateRequests.GetFriendList());
        }
        private void AddFriendButton_Click(object sender, EventArgs e)
        {
            if(FriendUsernameBox.Text == string.Empty)
            {
                MessageBox.Show("Введите имя друга в сотвественую форму.");
                return;
            }
            if(CreateRequests.AddFriend(FriendUsernameBox.Text))
            {
                RefreshFriendsToList(CreateRequests.GetFriendList());
            }
        }
        private void SendButton_Click(object sender, EventArgs e)
        {
            if(SendMessageBox.Text != string.Empty)
            {
                CreateRequests.SendMessage(FriendUsernameLable.Text, SendMessageBox.Text);
                ChatMessageBox.Text += SendMessageBox.Text + '\n' + '\r';
                SendMessageBox.Clear();
            }
        }

        public Label GetFriendUsername() => FriendUsernameLable;
        public TextBox GetChat() => ChatMessageBox;
    }
}