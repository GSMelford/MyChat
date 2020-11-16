using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;

namespace MyChatServer
{
    public class ClientObject
    {
        protected internal string Id { get; private set; }
        public string Username;
        public string Email;
        public string Password;
        public int EmailCode;
        protected internal NetworkStream StreamRequest { get; private set; }
        protected internal NetworkStream StreamSend { get; private set; }
        ServerObject Server;
        TcpClient TcpMainClient;
        TcpClient TcpSubClient;


        public ClientObject(TcpClient tcpMainClient, TcpClient tcpSubClient, ServerObject server)
        {
            Id = Guid.NewGuid().ToString();
            this.TcpMainClient = tcpMainClient;
            this.TcpSubClient = tcpSubClient;
            this.Server = server;
            server.AddConnection(this);
            Console.WriteLine($"Client ID: {Id}. Unknown connection.");
        }
        public void SetDataUser(string username, string email, string password)
        {
            this.Username = username;
            this.Email = email;
            this.Password = password;
        }
        public void Process()
        {
            try
            {
                StreamRequest = TcpMainClient.GetStream();
                StreamSend = TcpSubClient.GetStream();

                DistributorRequests distributorRequests = new DistributorRequests(this, Server);
                while (true)
                {
                    distributorRequests.RequestActivation(Server.GetRequest(Id));
                }
            }
            catch (Exception)
            {
                Console.WriteLine($"Client ID: {Id}. Disconnected.");
            }
            finally
            {
                Server.RemoveConnection(this.Id);
                Close();
            }
        }
        protected internal void SendAnswer(string json)
        {
            byte[] data = Encoding.UTF8.GetBytes(json);

            Int32 sizeRequests = data.Length;
            byte[] sizeRequestsByte = BitConverter.GetBytes(sizeRequests);

            StreamRequest.Write(sizeRequestsByte, 0, sizeRequestsByte.Length);
            StreamRequest.Write(data, 0, data.Length);
        }
        
        protected internal void Close()
        {
            if (StreamRequest != null)
                StreamRequest.Close();
            if (StreamSend != null)
                StreamSend.Close();
            if (TcpMainClient != null)
                TcpMainClient.Close();
            if (TcpSubClient != null)
                TcpSubClient.Close();
        }
    }
}