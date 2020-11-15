using MyChatClient.RequestsJSON;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        }
        private void AddFriend_button_Click(object sender, EventArgs e)
        {
            CreateRequests.AddFriend(FriendUsername_textBox.Text);
        }
        private void FriendButton_Click(object sender, EventArgs e)
        {
            string FriendUsername = (sender as Button).Tag.ToString();
            Chat_textBox.Text = CreateRequests.GetChat(FriendUsername);
        }
        private void RefreshList_button_Click(object sender, EventArgs e)
        {
            List<string> ListFriend = CreateRequests.GetFriendList();
            RefreshFriendsToList(ListFriend);
        }
        public void RefreshFriendsToList(List<string> FriendListServer)
        {
            foreach (var button in ClientLogic.FriendList)
            {
                FriendList_container.Controls.Remove(button);
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
                FriendList_container.Controls.Add(FriendButton);
                FriendButton.Click += new System.EventHandler(this.FriendButton_Click);
            }
        }
        private void MessengerForm_Load(object sender, EventArgs e)
        {
            List<string> ListFriend = CreateRequests.GetFriendList();
            RefreshFriendsToList(ListFriend);
        }
        private void Send_button_Click(object sender, EventArgs e)
        {
            CreateRequests.SendMessage(ClientLogic.FriendUserNow, Message_textBox.Text);
        }
    }
}