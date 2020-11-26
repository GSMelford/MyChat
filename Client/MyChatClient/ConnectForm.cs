using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyChatClient
{
    public partial class ConnectForm : Form
    {
        public ConnectForm()
        {
            InitializeComponent();
        }
        async private void TryConnect()
        {
            while (true)
            {
                if (!ClientLogic.ConnectToServer())
                {
                    TryConnectCounter.Text = "5";
                    for (int i = 0; i <= 5; i++)
                    {
                        TryConnectCounter.Text = $"{5 - i}";
                        await Task.Delay(1000);
                    }
                }
                else
                {
                    ClientLogic.Connected = true;
                    break;
                }
            }
            Close();
        }
        private void ConnectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ClientLogic.Connected)
                Environment.Exit(0);
        }
        private void ConnectForm_Shown(object sender, EventArgs e)
        {
            TryConnect();
        }
    }
}
