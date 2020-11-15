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
            this.FriendList_container = new System.Windows.Forms.Panel();
            this.Chat_textBox = new System.Windows.Forms.TextBox();
            this.Message_textBox = new System.Windows.Forms.TextBox();
            this.AddFriend_button = new System.Windows.Forms.Button();
            this.FriendUsername_textBox = new System.Windows.Forms.TextBox();
            this.Send_button = new System.Windows.Forms.Button();
            this.RefreshList_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FriendList_container
            // 
            this.FriendList_container.AutoScroll = true;
            this.FriendList_container.Location = new System.Drawing.Point(12, 65);
            this.FriendList_container.Name = "FriendList_container";
            this.FriendList_container.Size = new System.Drawing.Size(200, 270);
            this.FriendList_container.TabIndex = 0;
            // 
            // Chat_textBox
            // 
            this.Chat_textBox.Location = new System.Drawing.Point(218, 38);
            this.Chat_textBox.Multiline = true;
            this.Chat_textBox.Name = "Chat_textBox";
            this.Chat_textBox.Size = new System.Drawing.Size(570, 348);
            this.Chat_textBox.TabIndex = 1;
            // 
            // Message_textBox
            // 
            this.Message_textBox.Location = new System.Drawing.Point(218, 393);
            this.Message_textBox.Multiline = true;
            this.Message_textBox.Name = "Message_textBox";
            this.Message_textBox.Size = new System.Drawing.Size(495, 45);
            this.Message_textBox.TabIndex = 2;
            // 
            // AddFriend_button
            // 
            this.AddFriend_button.Location = new System.Drawing.Point(12, 393);
            this.AddFriend_button.Name = "AddFriend_button";
            this.AddFriend_button.Size = new System.Drawing.Size(200, 45);
            this.AddFriend_button.TabIndex = 3;
            this.AddFriend_button.Text = "Add";
            this.AddFriend_button.UseVisualStyleBackColor = true;
            this.AddFriend_button.Click += new System.EventHandler(this.AddFriend_button_Click);
            // 
            // FriendUsername_textBox
            // 
            this.FriendUsername_textBox.Location = new System.Drawing.Point(12, 341);
            this.FriendUsername_textBox.Multiline = true;
            this.FriendUsername_textBox.Name = "FriendUsername_textBox";
            this.FriendUsername_textBox.Size = new System.Drawing.Size(200, 45);
            this.FriendUsername_textBox.TabIndex = 4;
            // 
            // Send_button
            // 
            this.Send_button.Location = new System.Drawing.Point(719, 392);
            this.Send_button.Name = "Send_button";
            this.Send_button.Size = new System.Drawing.Size(69, 45);
            this.Send_button.TabIndex = 5;
            this.Send_button.Text = "Send";
            this.Send_button.UseVisualStyleBackColor = true;
            this.Send_button.Click += new System.EventHandler(this.Send_button_Click);
            // 
            // RefreshList_button
            // 
            this.RefreshList_button.Location = new System.Drawing.Point(188, 36);
            this.RefreshList_button.Name = "RefreshList_button";
            this.RefreshList_button.Size = new System.Drawing.Size(24, 23);
            this.RefreshList_button.TabIndex = 6;
            this.RefreshList_button.Text = "R";
            this.RefreshList_button.UseVisualStyleBackColor = true;
            this.RefreshList_button.Click += new System.EventHandler(this.RefreshList_button_Click);
            // 
            // MessengerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RefreshList_button);
            this.Controls.Add(this.Send_button);
            this.Controls.Add(this.FriendUsername_textBox);
            this.Controls.Add(this.AddFriend_button);
            this.Controls.Add(this.Message_textBox);
            this.Controls.Add(this.Chat_textBox);
            this.Controls.Add(this.FriendList_container);
            this.Name = "MessengerForm";
            this.Text = "MessengerForm";
            this.Load += new System.EventHandler(this.MessengerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel FriendList_container;
        private System.Windows.Forms.TextBox Chat_textBox;
        private System.Windows.Forms.TextBox Message_textBox;
        private System.Windows.Forms.Button AddFriend_button;
        private System.Windows.Forms.TextBox FriendUsername_textBox;
        private System.Windows.Forms.Button Send_button;
        private System.Windows.Forms.Button RefreshList_button;
    }
}