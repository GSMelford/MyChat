using System;
using System.IO;
using System.Net;
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
        public string IPClient;
        protected internal NetworkStream StreamRequest { get; private set; }
        protected internal NetworkStream StreamSend { get; private set; }
        ServerObject Server;
        TcpClient TcpMainClient;
        TcpClient TcpSubClient;
        public ClientObject(string IPClient, TcpClient tcpMainClient, TcpClient tcpSubClient, ServerObject server)
        {
            Id = Guid.NewGuid().ToString();
            this.TcpMainClient = tcpMainClient;
            this.TcpSubClient = tcpSubClient;
            this.Server = server;
            this.IPClient = IPClient;
            server.AddConnection(this);
            Console.WriteLine($"Client IP: {IPClient}. Unknown connection.");
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
                    if (StreamRequest.CanRead || StreamRequest.CanRead)
                        distributorRequests.RequestActivation(Server.GetRequest(Id));
                    else
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Disconnection...");
            }
            finally
            {
                Console.WriteLine($"Client IP: {IPClient}. Disconnected.");
                Server.RemoveConnection(this.Id);
                Server.SendUpdateOnline();
                Close();
            }
        }
        protected internal void SendAnswer(string json)
        {
            try
            {
                byte[] data = Encoding.UTF8.GetBytes(json);

                Int32 sizeRequests = data.Length;
                byte[] sizeRequestsByte = BitConverter.GetBytes(sizeRequests);

                StreamRequest.Write(sizeRequestsByte, 0, sizeRequestsByte.Length);
                StreamRequest.Write(data, 0, data.Length);
            }
            catch (Exception)
            {
                Console.WriteLine("SendAnswer() Error.");
            }
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