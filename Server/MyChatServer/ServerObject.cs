using MyChatServer.RequestsJSON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyChatServer
{
    public class ServerObject
    {
        static TcpListener tcpMainListener;
        static TcpListener tcpSubListener;
        static public List<ClientObject> users = new List<ClientObject>(); // Список все 
        protected internal void AddConnection(ClientObject clientObject)
        {
            users.Add(clientObject);
        }
        protected internal void RemoveConnection(string id)
        {
            // получаем по id закрытое подключение
            ClientObject client = users.FirstOrDefault(c => c.Id == id);
            if (client != null)
                users.Remove(client);
        }
        protected internal void Listen()
        {
            try
            {
                tcpMainListener = new TcpListener(IPAddress.Any, 1234);
                tcpSubListener = new TcpListener(IPAddress.Any, 1235);
                tcpMainListener.Start();
                tcpSubListener.Start();

                Console.WriteLine("The server is running. Waiting for connection...");

                while (true)
                {
                    TcpClient tcpMainClient = tcpMainListener.AcceptTcpClient();
                    Console.WriteLine("Stream 1");
                    TcpClient tcpSubClient = tcpSubListener.AcceptTcpClient();
                    Console.WriteLine("Stream 2");
                    ClientObject clientObject = new ClientObject(tcpMainClient, tcpSubClient , this);
                    Thread clientThread = new Thread(new ThreadStart(clientObject.Process));
                    clientThread.Start();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Disconnect();
            }
        }
        protected internal string GetRequest(string id)
        {
            Console.WriteLine($"Client ID: {id}. We are awaiting a request.");
            ClientObject client = users.FirstOrDefault(c => c.Id == id);
            StringBuilder builder = new StringBuilder();
            int bytes = 0;
            byte[] sizeRequestsByte = new byte[4];
            client.StreamRequest.Read(sizeRequestsByte, 0, sizeRequestsByte.Length);
            int a = BitConverter.ToInt32(sizeRequestsByte, 0);
            byte[] requestsByte = new byte[BitConverter.ToInt32(sizeRequestsByte, 0)];
            bytes = client.StreamRequest.Read(requestsByte, 0, BitConverter.ToInt32(sizeRequestsByte, 0));
            builder.Append(Encoding.UTF8.GetString(requestsByte, 0, bytes));
            return builder.ToString();
        }

        async protected internal void SendMessage(string json, string friendUsername)
        {
            await Task.Run(()=> 
            {
                ClientObject client = users.FirstOrDefault(c => c.Username == friendUsername);
                if(client!=null)
                {
                    byte[] data = Encoding.UTF8.GetBytes(json);

                    Int32 sizeRequests = data.Length;
                    byte[] sizeRequestsByte = BitConverter.GetBytes(sizeRequests);

                    client.StreamSend.Write(sizeRequestsByte, 0, sizeRequestsByte.Length);
                    client.StreamSend.Write(data, 0, data.Length);
                }
            });
        }

        protected internal void Disconnect()
        {
            tcpMainListener.Stop(); //остановка сервера
            tcpSubListener.Stop();

            for (int i = 0; i < users.Count; i++)
            {
                users[i].Close(); //отключение клиента
            }
            Environment.Exit(0); //завершение процесса
        }
    }
}