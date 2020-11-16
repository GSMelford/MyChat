using System;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Text.Json;
using System.Runtime.InteropServices;
using System.Text;
using MyChatClient.RequestsJSON;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading;
using System.IO;
using MyChatClient.ServerAnswerJSON;

namespace MyChatClient
{
    static class ClientLogic
    {
        public static string Username = string.Empty;
        public static string Email = string.Empty;
        public static string Password = string.Empty;
        public static string FriendUserNow = string.Empty;
        public static bool Registered = false;
        public static bool Authorization = false;

        private const string Host = "178.150.32.105";
        private const int Port = 1234;
        private const int Port2 = 1235;

        static TcpClient Client;
        static TcpClient SubClient;
        static NetworkStream StreamRequest;
        static NetworkStream StreamAnswer;
        static public MessengerForm messengerForm;

        public static List<Button> FriendList = new List<Button>();
        public static bool ConnectToServer()
        {
            Client = new TcpClient();
            SubClient = new TcpClient();
            try
            {
                Client.Connect(Host, Port);
                SubClient.Connect(Host, Port2);
                StreamRequest = Client.GetStream();
                StreamAnswer = SubClient.GetStream();
                return true;
            }
            catch (Exception )
            {
                return false;
            }
        }
        public static void SendMessage(string json)
        {
            byte[] data = Encoding.UTF8.GetBytes(json);

            Int32 sizeRequests = data.Length;
            byte[] sizeRequestsByte = BitConverter.GetBytes(sizeRequests);

            StreamRequest.Write(sizeRequestsByte, 0, sizeRequestsByte.Length);
            StreamRequest.Write(data, 0, data.Length);
        }
        public static string GetAnswer()
        {
            StringBuilder builder = new StringBuilder();
            int bytes = 0;
            byte[] sizeRequestsByte = new byte[4];
            StreamRequest.Read(sizeRequestsByte, 0, sizeRequestsByte.Length);
            byte[] requestsByte = new byte[BitConverter.ToInt32(sizeRequestsByte, 0)];
            bytes = StreamRequest.Read(requestsByte, 0, BitConverter.ToInt32(sizeRequestsByte, 0));
            builder.Append(Encoding.UTF8.GetString(requestsByte, 0, bytes));
            return builder.ToString();
        }

        public static void GetServerAnswer()
        {
            DistributorAnswer distributorAnswer = new DistributorAnswer(messengerForm);
            while (true)
            {
                try
                {
                    StringBuilder builder = new StringBuilder();
                    int bytes = 0;
                    byte[] sizeRequestsByte = new byte[4];
                    StreamAnswer.Read(sizeRequestsByte, 0, sizeRequestsByte.Length);
                    byte[] requestsByte = new byte[BitConverter.ToInt32(sizeRequestsByte, 0)];
                    bytes = StreamAnswer.Read(requestsByte, 0, BitConverter.ToInt32(sizeRequestsByte, 0));
                    builder.Append(Encoding.UTF8.GetString(requestsByte, 0, bytes));
                    distributorAnswer.AnswerActivation(builder.ToString());
                }
                catch (Exception)
                {
                    MessageBox.Show("Что-то пошло не так с GetServerAnswer();");
                    break;
                }
            }
        }

        static void Disconnect()
        {
            if (StreamRequest != null)
                StreamRequest.Close();
            if (StreamAnswer != null)
                StreamAnswer.Close();
            if (Client != null)
                Client.Close();
            if (SubClient != null)
                SubClient.Close();
        }
    }
}
