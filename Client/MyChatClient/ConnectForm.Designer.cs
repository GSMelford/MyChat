
namespace MyChatClient
{
    partial class ConnectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectForm));
            this.ConnectToServer = new System.Windows.Forms.Label();
            this.TryConnectCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConnectToServer
            // 
            this.ConnectToServer.Font = new System.Drawing.Font("Open Sans SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConnectToServer.ForeColor = System.Drawing.Color.White;
            this.ConnectToServer.Location = new System.Drawing.Point(12, 9);
            this.ConnectToServer.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ConnectToServer.Name = "ConnectToServer";
            this.ConnectToServer.Size = new System.Drawing.Size(338, 69);
            this.ConnectToServer.TabIndex = 0;
            this.ConnectToServer.Text = "Сервер не відповідає. Спроба підключення через:";
            // 
            // TryConnectCounter
            // 
            this.TryConnectCounter.AutoSize = true;
            this.TryConnectCounter.Font = new System.Drawing.Font("Open Sans SemiBold", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TryConnectCounter.ForeColor = System.Drawing.Color.White;
            this.TryConnectCounter.Location = new System.Drawing.Point(389, 22);
            this.TryConnectCounter.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TryConnectCounter.Name = "TryConnectCounter";
            this.TryConnectCounter.Size = new System.Drawing.Size(52, 41);
            this.TryConnectCounter.TabIndex = 1;
            this.TryConnectCounter.Text = "10";
            // 
            // ConnectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(487, 81);
            this.Controls.Add(this.TryConnectCounter);
            this.Controls.Add(this.ConnectToServer);
            this.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ConnectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Підключення... MyChat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConnectForm_FormClosing);
            this.Shown += new System.EventHandler(this.ConnectForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ConnectToServer;
        private System.Windows.Forms.Label TryConnectCounter;
    }
}