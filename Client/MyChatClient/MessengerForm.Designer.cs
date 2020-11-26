namespace MyChatClient
{
    partial class MessengerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessengerForm));
            this.FriendListContainer = new System.Windows.Forms.Panel();
            this.ChatMessageBox = new System.Windows.Forms.TextBox();
            this.SendMessageBox = new System.Windows.Forms.TextBox();
            this.AddFriendButton = new System.Windows.Forms.Button();
            this.FriendUsernameBox = new System.Windows.Forms.TextBox();
            this.UsernameLable = new System.Windows.Forms.Label();
            this.FriendUsernameLable = new System.Windows.Forms.Label();
            this.StatusFriend = new System.Windows.Forms.Label();
            this.SendButton = new System.Windows.Forms.Button();
            this.VideoCallButton = new System.Windows.Forms.Button();
            this.VoiceButton = new System.Windows.Forms.Button();
            this.AttachFileButton = new System.Windows.Forms.Button();
            this.MenuButton = new System.Windows.Forms.Button();
            this.CallButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FriendListContainer
            // 
            this.FriendListContainer.AutoScroll = true;
            this.FriendListContainer.Location = new System.Drawing.Point(14, 64);
            this.FriendListContainer.Margin = new System.Windows.Forms.Padding(5);
            this.FriendListContainer.Name = "FriendListContainer";
            this.FriendListContainer.Size = new System.Drawing.Size(236, 579);
            this.FriendListContainer.TabIndex = 0;
            // 
            // ChatMessageBox
            // 
            this.ChatMessageBox.BackColor = System.Drawing.Color.Silver;
            this.ChatMessageBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChatMessageBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ChatMessageBox.Location = new System.Drawing.Point(260, 64);
            this.ChatMessageBox.Margin = new System.Windows.Forms.Padding(5);
            this.ChatMessageBox.Multiline = true;
            this.ChatMessageBox.Name = "ChatMessageBox";
            this.ChatMessageBox.ReadOnly = true;
            this.ChatMessageBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ChatMessageBox.Size = new System.Drawing.Size(921, 605);
            this.ChatMessageBox.TabIndex = 1;
            // 
            // SendMessageBox
            // 
            this.SendMessageBox.BackColor = System.Drawing.Color.Silver;
            this.SendMessageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SendMessageBox.Enabled = false;
            this.SendMessageBox.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendMessageBox.Location = new System.Drawing.Point(306, 677);
            this.SendMessageBox.Margin = new System.Windows.Forms.Padding(5);
            this.SendMessageBox.Multiline = true;
            this.SendMessageBox.Name = "SendMessageBox";
            this.SendMessageBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SendMessageBox.Size = new System.Drawing.Size(790, 56);
            this.SendMessageBox.TabIndex = 2;
            // 
            // AddFriendButton
            // 
            this.AddFriendButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddFriendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFriendButton.ForeColor = System.Drawing.Color.White;
            this.AddFriendButton.Location = new System.Drawing.Point(14, 692);
            this.AddFriendButton.Margin = new System.Windows.Forms.Padding(5);
            this.AddFriendButton.Name = "AddFriendButton";
            this.AddFriendButton.Size = new System.Drawing.Size(236, 41);
            this.AddFriendButton.TabIndex = 3;
            this.AddFriendButton.Text = "Додати друга";
            this.AddFriendButton.UseVisualStyleBackColor = true;
            this.AddFriendButton.Click += new System.EventHandler(this.AddFriendButton_Click);
            // 
            // FriendUsernameBox
            // 
            this.FriendUsernameBox.BackColor = System.Drawing.Color.Silver;
            this.FriendUsernameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FriendUsernameBox.Location = new System.Drawing.Point(14, 653);
            this.FriendUsernameBox.Margin = new System.Windows.Forms.Padding(5);
            this.FriendUsernameBox.Multiline = true;
            this.FriendUsernameBox.Name = "FriendUsernameBox";
            this.FriendUsernameBox.Size = new System.Drawing.Size(236, 32);
            this.FriendUsernameBox.TabIndex = 4;
            // 
            // UsernameLable
            // 
            this.UsernameLable.AutoSize = true;
            this.UsernameLable.Font = new System.Drawing.Font("Open Sans SemiBold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsernameLable.ForeColor = System.Drawing.Color.White;
            this.UsernameLable.Location = new System.Drawing.Point(12, 9);
            this.UsernameLable.Name = "UsernameLable";
            this.UsernameLable.Size = new System.Drawing.Size(173, 43);
            this.UsernameLable.TabIndex = 8;
            this.UsernameLable.Text = "YourName";
            // 
            // FriendUsernameLable
            // 
            this.FriendUsernameLable.AutoSize = true;
            this.FriendUsernameLable.Font = new System.Drawing.Font("Open Sans SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FriendUsernameLable.ForeColor = System.Drawing.Color.White;
            this.FriendUsernameLable.Location = new System.Drawing.Point(254, 4);
            this.FriendUsernameLable.Name = "FriendUsernameLable";
            this.FriendUsernameLable.Size = new System.Drawing.Size(159, 33);
            this.FriendUsernameLable.TabIndex = 9;
            this.FriendUsernameLable.Text = "FriendName";
            // 
            // StatusFriend
            // 
            this.StatusFriend.AutoSize = true;
            this.StatusFriend.ForeColor = System.Drawing.Color.Silver;
            this.StatusFriend.Location = new System.Drawing.Point(256, 37);
            this.StatusFriend.Name = "StatusFriend";
            this.StatusFriend.Size = new System.Drawing.Size(84, 22);
            this.StatusFriend.TabIndex = 10;
            this.StatusFriend.Text = "оффлайн";
            // 
            // SendButton
            // 
            this.SendButton.Enabled = false;
            this.SendButton.FlatAppearance.BorderSize = 0;
            this.SendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SendButton.Image = ((System.Drawing.Image)(resources.GetObject("SendButton.Image")));
            this.SendButton.Location = new System.Drawing.Point(1147, 685);
            this.SendButton.Margin = new System.Windows.Forms.Padding(5);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(46, 39);
            this.SendButton.TabIndex = 5;
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // VideoCallButton
            // 
            this.VideoCallButton.FlatAppearance.BorderSize = 0;
            this.VideoCallButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VideoCallButton.Image = global::MyChatClient.Properties.Resources.baseline_video_call_white_24dp;
            this.VideoCallButton.Location = new System.Drawing.Point(1041, 6);
            this.VideoCallButton.Name = "VideoCallButton";
            this.VideoCallButton.Size = new System.Drawing.Size(38, 55);
            this.VideoCallButton.TabIndex = 15;
            this.VideoCallButton.UseVisualStyleBackColor = true;
            this.VideoCallButton.Click += new System.EventHandler(this.VideoCallButton_Click);
            // 
            // VoiceButton
            // 
            this.VoiceButton.FlatAppearance.BorderSize = 0;
            this.VoiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VoiceButton.Image = global::MyChatClient.Properties.Resources.baseline_settings_voice_white_24dp;
            this.VoiceButton.Location = new System.Drawing.Point(260, 677);
            this.VoiceButton.Name = "VoiceButton";
            this.VoiceButton.Size = new System.Drawing.Size(38, 55);
            this.VoiceButton.TabIndex = 14;
            this.VoiceButton.UseVisualStyleBackColor = true;
            this.VoiceButton.Click += new System.EventHandler(this.VoiceButton_Click);
            // 
            // AttachFileButton
            // 
            this.AttachFileButton.FlatAppearance.BorderSize = 0;
            this.AttachFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AttachFileButton.Image = global::MyChatClient.Properties.Resources.baseline_attach_file_white_24dp;
            this.AttachFileButton.Location = new System.Drawing.Point(1104, 677);
            this.AttachFileButton.Name = "AttachFileButton";
            this.AttachFileButton.Size = new System.Drawing.Size(38, 55);
            this.AttachFileButton.TabIndex = 13;
            this.AttachFileButton.UseVisualStyleBackColor = true;
            this.AttachFileButton.Click += new System.EventHandler(this.AttachFileButton_Click);
            // 
            // MenuButton
            // 
            this.MenuButton.FlatAppearance.BorderSize = 0;
            this.MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuButton.Image = global::MyChatClient.Properties.Resources.baseline_more_vert_white_24dp;
            this.MenuButton.Location = new System.Drawing.Point(1152, 4);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(31, 59);
            this.MenuButton.TabIndex = 12;
            this.MenuButton.UseVisualStyleBackColor = true;
            // 
            // CallButton
            // 
            this.CallButton.FlatAppearance.BorderSize = 0;
            this.CallButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CallButton.Image = global::MyChatClient.Properties.Resources.baseline_call_white_24dp;
            this.CallButton.Location = new System.Drawing.Point(1085, 4);
            this.CallButton.Name = "CallButton";
            this.CallButton.Size = new System.Drawing.Size(61, 59);
            this.CallButton.TabIndex = 11;
            this.CallButton.UseVisualStyleBackColor = true;
            this.CallButton.Click += new System.EventHandler(this.CallButton_Click);
            // 
            // MessengerForm
            // 
            this.AcceptButton = this.SendButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1195, 744);
            this.Controls.Add(this.VideoCallButton);
            this.Controls.Add(this.VoiceButton);
            this.Controls.Add(this.AttachFileButton);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.CallButton);
            this.Controls.Add(this.StatusFriend);
            this.Controls.Add(this.FriendUsernameLable);
            this.Controls.Add(this.UsernameLable);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.FriendUsernameBox);
            this.Controls.Add(this.AddFriendButton);
            this.Controls.Add(this.SendMessageBox);
            this.Controls.Add(this.ChatMessageBox);
            this.Controls.Add(this.FriendListContainer);
            this.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MessengerForm";
            this.Text = "MyChat";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MessengerForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel FriendListContainer;
        private System.Windows.Forms.TextBox ChatMessageBox;
        private System.Windows.Forms.TextBox SendMessageBox;
        private System.Windows.Forms.Button AddFriendButton;
        private System.Windows.Forms.TextBox FriendUsernameBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Label UsernameLable;
        private System.Windows.Forms.Label FriendUsernameLable;
        private System.Windows.Forms.Label StatusFriend;
        private System.Windows.Forms.Button CallButton;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Button AttachFileButton;
        private System.Windows.Forms.Button VoiceButton;
        private System.Windows.Forms.Button VideoCallButton;
    }
}