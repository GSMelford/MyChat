using System;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Text.Json;
using System.Runtime.InteropServices;
using System.Text;
using MyChatClient.RequestsJSON;

namespace MyChatClient
{
    class ClientLogic
    {
        public string Username { get; }
        public string Email { get; }
        public string Password { get; }
        private const string Host = "178.150.32.105";
        private const int Port = 1234;
        static TcpClient Client;
        static NetworkStream Stream;
        static CreateRequests AnswerDistributor;
        public ClientLogic(string username, string email, string password)
        {
            this.Username = username;
            this.Email = email;
            this.Password = password;
            AnswerDistributor = new CreateRequests(this);
        }

        public static bool ServerConnection()
        {
            Client = new TcpClient();
            try
            {
                Client.Connect(Host, Port);
                Stream = Client.GetStream();
                return true;
            }
            catch (Exception )
            {
                return false;
            }
        }

        public static bool CheckConnection()
        {
            return Client.Connected;
        }
        public void SendMessage(string json)
        {
            byte[] data = Encoding.UTF8.GetBytes(json);

            Int32 sizeRequests = data.Length;
            byte[] sizeRequestsByte = BitConverter.GetBytes(sizeRequests);

            Stream.Write(sizeRequestsByte, 0, sizeRequestsByte.Length);
            Stream.Write(data, 0, data.Length);
        }
        public string GetMessage()
        {
            StringBuilder builder = new StringBuilder();
            int bytes = 0;
            byte[] sizeRequestsByte = new byte[4];
            Stream.Read(sizeRequestsByte, 0, sizeRequestsByte.Length);
            byte[] requestsByte = new byte[BitConverter.ToInt32(sizeRequestsByte, 0)];
            bytes = Stream.Read(requestsByte, 0, BitConverter.ToInt32(sizeRequestsByte, 0));
            builder.Append(Encoding.UTF8.GetString(requestsByte, 0, bytes));
            return builder.ToString();
        }
        static void Disconnect()
        {
            if (Stream != null)
                Stream.Close();
            if (Client != null)
                Client.Close();
        }
    }
    
}
