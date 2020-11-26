using System;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Text;
using System.Collections.Generic;
using MyChatClient.ServerAnswerJSON;

namespace MyChatClient
{
    static class ClientLogic
    {
        public static string Username = string.Empty;
        public static string Email = string.Empty;
        public static string Password = string.Empty;
        public static bool Registered = false;
        public static bool Connected = false;

        private const string Host = "178.150.32.105";
        private const int Port = 1234;
        private const int Port2 = 1235;

        static TcpClient Client;
        static TcpClient SubClient;
        static NetworkStream StreamRequest;
        static NetworkStream StreamAnswer;
        static public MessengerForm messengerForm;

        public static List<Button> FriendList = new List<Button>();
        public static List<Button> FriendListRemove = new List<Button>();
        public static List<string> UsersOnline = new List<string>();

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
            try
            {
                if (Connected)
                {
                    byte[] data = Encoding.UTF8.GetBytes(json);

                    Int32 sizeRequests = data.Length;
                    byte[] sizeRequestsByte = BitConverter.GetBytes(sizeRequests);

                    StreamRequest.Write(sizeRequestsByte, 0, sizeRequestsByte.Length);
                    StreamRequest.Write(data, 0, data.Length);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("SendMessage() Error.");
            }
        }
        public static string GetAnswer()
        {
            try
            {
                if (Connected)
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
            }
            catch (Exception)
            {
                MessageBox.Show("GetAnswer() Error.");
            }
            return string.Empty;
        }
        public static void GetServerAnswer()
        {
            DistributorAnswer distributorAnswer = new DistributorAnswer(messengerForm);
            while (true)
            {
                if(Connected)
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
                        messengerForm.AsyncTryConnectToServer();
                        break;
                    }
                }
            }
        }
        public static void Disconnect()
        {
            if(Connected)
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
}
