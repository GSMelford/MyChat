using MyChatClient.RequestsJSON;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            StatusFriend.Visible = false;
            FriendUsernameLable.Visible = false;

            if (ClientDirectory.LocalAuthorization())
            {
                UsernameLable.Text = ClientLogic.Username;
                ClientLogic.Registered = true;
            }

            AsyncTryConnectToServer();
        }
        async public void AsyncTryConnectToServer()
        {
            await Task.Run(() =>
            {
                try
                {
                    ClientLogic.Connected = false;
                    ConnectForm connectForm = new ConnectForm();
                    connectForm.ShowDialog();
                    if (ClientLogic.Registered)
                    {
                        if (!CreateRequests.Authorization(ClientLogic.Email, ClientLogic.Password))
                        {
                            RegistrationForm registrationForm = new RegistrationForm(this);
                            Invoke((MethodInvoker)(() =>
                            {
                                this.Hide();
                                registrationForm.ShowDialog();
                            }));
                        }
                    }
                    else
                    {
                        RegistrationForm registrationForm = new RegistrationForm(this);
                        Invoke((MethodInvoker)(() =>
                        {
                            this.Hide();
                            registrationForm.ShowDialog();
                        }));
                    }

                    ClientLogic.messengerForm = this;

                    Task receive = new Task(() => { ClientLogic.GetServerAnswer(); });
                    receive.Start();
                    Invoke((MethodInvoker)(() =>
                    {
                        UsernameLable.Text = ClientLogic.Username;
                    }));
                    ClientLogic.Connected = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("AsyncTryConnectToServer() Error.");
                }
            });
        }
        private void FriendButton_Click(object sender, EventArgs e)
        {
            if(ClientLogic.Connected)
            {
                string FriendUsername = (sender as Button).Tag.ToString();
                ChatMessageBox.Text = CreateRequests.GetChat(FriendUsername);
                StatusFriend.Visible = true;
                FriendUsernameLable.Visible = true;
                FriendUsernameLable.Text = FriendUsername;
                SendButton.Enabled = true;
                SendMessageBox.Enabled = true;
                RefreshUsersStatus(ClientLogic.UsersOnline);
            }
        }
        private void FriendButtonRemove_Click (object sender, EventArgs e)
        {
            if (ClientLogic.Connected)
            {
                string FriendUsername = (sender as Button).Tag.ToString();
                if (CreateRequests.RemoveFriend(FriendUsername))
                {
                    MessageBox.Show($"Ваш приятель {FriendUsername} був видалений.");
                    if (FriendUsername == FriendUsernameLable.Text)
                    {
                        FriendUsernameLable.Text = "Ім'я вашого приятеля:";
                        ChatMessageBox.Clear();
                        ChatMessageBox.Enabled = false;
                        SendMessageBox.Clear();
                        SendMessageBox.Enabled = false;
                        SendButton.Enabled = false;
                        StatusFriend.Visible = false;
                        FriendUsernameLable.Visible = false;
                    }
                }
                RefreshFriendsToList(CreateRequests.GetFriendList());
            }
        }
        public void RefreshFriendsToList(List<string> FriendListServer)
        {
            if(FriendListServer == null)
                return;
            Invoke((MethodInvoker) (()=> 
            {
                CounterFButton = 0;
                foreach (var button in ClientLogic.FriendList)
                {
                    FriendListContainer.Controls.Remove(button);
                }
                foreach (var button in ClientLogic.FriendListRemove)
                {
                    FriendListContainer.Controls.Remove(button);
                }
                foreach (var button in FriendListServer)
                {
                    Button FriendButton = new Button();
                    FriendButton.Location = new Point(0, CounterFButton);
                    FriendButton.Width = 200;
                    FriendButton.Height = 32;
                    FriendButton.Tag = button;
                    FriendButton.Text = button;
                    FriendButton.ForeColor = Color.White;
                    FriendButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                    FriendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    ClientLogic.FriendList.Add(FriendButton);
                    FriendListContainer.Controls.Add(FriendButton);
                    FriendButton.Click += new System.EventHandler(this.FriendButton_Click);

                    Button FriendButtonRemove = new Button();
                    FriendButtonRemove.Location = new Point(204, CounterFButton);
                    FriendButtonRemove.Width = 32;
                    FriendButtonRemove.Height = 32;
                    FriendButtonRemove.Tag = button;
                    FriendButtonRemove.Text = "X";
                    FriendButtonRemove.ForeColor = Color.White;
                    FriendButtonRemove.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                    FriendButtonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    ClientLogic.FriendListRemove.Add(FriendButtonRemove);
                    FriendListContainer.Controls.Add(FriendButtonRemove);
                    FriendButtonRemove.Click += new System.EventHandler(this.FriendButtonRemove_Click);

                    CounterFButton += 34;
                }
            }));
        }
        public void RefreshUsersStatus(List<string> usersOnline)
        {
            Invoke((MethodInvoker)(() =>
            {
                ClientLogic.UsersOnline = usersOnline;

                foreach (var button in ClientLogic.FriendList)
                {
                    foreach (var user in ClientLogic.UsersOnline)
                    {
                        if (button.Text == user)
                        {
                            button.ForeColor = Color.LightGreen;
                            break;
                        }
                        else
                            button.ForeColor = Color.LightGray;
                    }
                }

                foreach (var user in ClientLogic.UsersOnline)
                {
                    if (FriendUsernameLable.Text == user)
                    {
                        StatusFriend.Text = "онлайн";
                        StatusFriend.ForeColor = Color.LightGreen;
                        break;
                    }
                    else
                    {
                        StatusFriend.Text = "офлайн";
                        StatusFriend.ForeColor = Color.LightGray;
                    }
                }
            }));
        }
        private void AddFriendButton_Click(object sender, EventArgs e)
        {
            if (ClientLogic.Connected)
            {
                if (FriendUsernameBox.Text == string.Empty)
                {
                    MessageBox.Show("Введіть ім'я друга в сотвественую форму.");
                    return;
                }
                if (CreateRequests.AddFriend(FriendUsernameBox.Text))
                {
                    RefreshFriendsToList(CreateRequests.GetFriendList());
                    RefreshUsersStatus(CreateRequests.RefreshUsersOnline());
                    FriendUsernameBox.Clear();
                }
            }
        }
        private void SendButton_Click(object sender, EventArgs e)
        {
            if(ClientLogic.Connected)
            {
                if (SendMessageBox.Text != string.Empty)
                {
                    DateTime date = DateTime.Now;
                    string message = $"[{date.ToShortTimeString()}] {ClientLogic.Username}: {SendMessageBox.Text}";

                    CreateRequests.SendMessage(FriendUsernameLable.Text, message);
                    ChatMessageBox.Text += message;
                    ChatMessageBox.Text += "\r";
                    ChatMessageBox.Text += "\n";
                    SendMessageBox.Clear();
                }
            }
        }
        public Label GetFriendUsername() => FriendUsernameLable;
        public TextBox GetChat() => ChatMessageBox;
        public Panel GetPanelFriendList() => FriendListContainer;
        private void MessengerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
        private void VoiceButton_Click(object sender, EventArgs e)
        {

        }
        private void AttachFileButton_Click(object sender, EventArgs e)
        {
           
        }
        private void VideoCallButton_Click(object sender, EventArgs e)
        {
            
        }
        private void CallButton_Click(object sender, EventArgs e)
        {
            MainClallForm mainClallForm = new MainClallForm();
            mainClallForm.Show();
        }
    }
}