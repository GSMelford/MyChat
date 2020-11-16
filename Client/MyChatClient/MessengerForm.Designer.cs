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
            this.FriendListContainer = new System.Windows.Forms.Panel();
            this.ChatMessageBox = new System.Windows.Forms.TextBox();
            this.SendMessageBox = new System.Windows.Forms.TextBox();
            this.AddFriendButton = new System.Windows.Forms.Button();
            this.FriendUsernameBox = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.FriendListLabel = new System.Windows.Forms.Label();
            this.UsernameLable = new System.Windows.Forms.Label();
            this.FriendUsernameLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FriendListContainer
            // 
            this.FriendListContainer.AutoScroll = true;
            this.FriendListContainer.Location = new System.Drawing.Point(20, 110);
            this.FriendListContainer.Margin = new System.Windows.Forms.Padding(5);
            this.FriendListContainer.Name = "FriendListContainer";
            this.FriendListContainer.Size = new System.Drawing.Size(333, 457);
            this.FriendListContainer.TabIndex = 0;
            // 
            // ChatMessageBox
            // 
            this.ChatMessageBox.Location = new System.Drawing.Point(363, 64);
            this.ChatMessageBox.Margin = new System.Windows.Forms.Padding(5);
            this.ChatMessageBox.Multiline = true;
            this.ChatMessageBox.Name = "ChatMessageBox";
            this.ChatMessageBox.ReadOnly = true;
            this.ChatMessageBox.Size = new System.Drawing.Size(947, 586);
            this.ChatMessageBox.TabIndex = 1;
            // 
            // SendMessageBox
            // 
            this.SendMessageBox.Enabled = false;
            this.SendMessageBox.Location = new System.Drawing.Point(363, 665);
            this.SendMessageBox.Margin = new System.Windows.Forms.Padding(5);
            this.SendMessageBox.Multiline = true;
            this.SendMessageBox.Name = "SendMessageBox";
            this.SendMessageBox.Size = new System.Drawing.Size(822, 73);
            this.SendMessageBox.TabIndex = 2;
            // 
            // AddFriendButton
            // 
            this.AddFriendButton.Location = new System.Drawing.Point(20, 665);
            this.AddFriendButton.Margin = new System.Windows.Forms.Padding(5);
            this.AddFriendButton.Name = "AddFriendButton";
            this.AddFriendButton.Size = new System.Drawing.Size(333, 76);
            this.AddFriendButton.TabIndex = 3;
            this.AddFriendButton.Text = "Добавить друга";
            this.AddFriendButton.UseVisualStyleBackColor = true;
            this.AddFriendButton.Click += new System.EventHandler(this.AddFriendButton_Click);
            // 
            // FriendUsernameBox
            // 
            this.FriendUsernameBox.Location = new System.Drawing.Point(20, 577);
            this.FriendUsernameBox.Margin = new System.Windows.Forms.Padding(5);
            this.FriendUsernameBox.Multiline = true;
            this.FriendUsernameBox.Name = "FriendUsernameBox";
            this.FriendUsernameBox.Size = new System.Drawing.Size(331, 73);
            this.FriendUsernameBox.TabIndex = 4;
            // 
            // SendButton
            // 
            this.SendButton.Enabled = false;
            this.SendButton.Location = new System.Drawing.Point(1198, 663);
            this.SendButton.Margin = new System.Windows.Forms.Padding(5);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(115, 76);
            this.SendButton.TabIndex = 5;
            this.SendButton.Text = "Отправить";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // FriendListLabel
            // 
            this.FriendListLabel.AutoSize = true;
            this.FriendListLabel.Font = new System.Drawing.Font("Open Sans SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FriendListLabel.Location = new System.Drawing.Point(20, 75);
            this.FriendListLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.FriendListLabel.Name = "FriendListLabel";
            this.FriendListLabel.Size = new System.Drawing.Size(184, 30);
            this.FriendListLabel.TabIndex = 7;
            this.FriendListLabel.Text = "Список друзей:";
            // 
            // UsernameLable
            // 
            this.UsernameLable.AutoSize = true;
            this.UsernameLable.Font = new System.Drawing.Font("Open Sans SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsernameLable.Location = new System.Drawing.Point(12, 9);
            this.UsernameLable.Name = "UsernameLable";
            this.UsernameLable.Size = new System.Drawing.Size(185, 43);
            this.UsernameLable.TabIndex = 8;
            this.UsernameLable.Text = "YourName";
            // 
            // FriendUsernameLable
            // 
            this.FriendUsernameLable.AutoSize = true;
            this.FriendUsernameLable.Font = new System.Drawing.Font("Open Sans SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FriendUsernameLable.Location = new System.Drawing.Point(355, 9);
            this.FriendUsernameLable.Name = "FriendUsernameLable";
            this.FriendUsernameLable.Size = new System.Drawing.Size(210, 43);
            this.FriendUsernameLable.TabIndex = 9;
            this.FriendUsernameLable.Text = "FriendName";
            // 
            // MessengerForm
            // 
            this.AcceptButton = this.SendButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 762);
            this.Controls.Add(this.FriendUsernameLable);
            this.Controls.Add(this.UsernameLable);
            this.Controls.Add(this.FriendListLabel);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.FriendUsernameBox);
            this.Controls.Add(this.AddFriendButton);
            this.Controls.Add(this.SendMessageBox);
            this.Controls.Add(this.ChatMessageBox);
            this.Controls.Add(this.FriendListContainer);
            this.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MessengerForm";
            this.Text = "MyChat";
            this.Load += new System.EventHandler(this.MessengerForm_Load);
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
        private System.Windows.Forms.Label FriendListLabel;
        private System.Windows.Forms.Label UsernameLable;
        private System.Windows.Forms.Label FriendUsernameLable;
    }
}