using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace MyChatServer
{
    public class ServerObject
    {
        static TcpListener tcpListener; // сервер для прослушивания
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
        protected internal void Listen() //Метод который работает в потоке при запуске сервера, он ждет когда подключиться новый пользователь.
        {
            try
            {
                tcpListener = new TcpListener(IPAddress.Any, 1234);
                tcpListener.Start();
                Console.WriteLine("The server is running. Waiting for connection...");

                while (true)
                {
                    TcpClient tcpClient = tcpListener.AcceptTcpClient(); //Принимает нового пользователя
                    ClientObject clientObject = new ClientObject(tcpClient, this);
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
        protected internal string GetMessage(string id)
        {
            Console.WriteLine($"Client ID: {id}. We are awaiting a request.");
            ClientObject client = users.FirstOrDefault(c => c.Id == id);
            StringBuilder builder = new StringBuilder();
            int bytes = 0;
            byte[] sizeRequestsByte = new byte[4];
            client.Stream.Read(sizeRequestsByte, 0, sizeRequestsByte.Length);
            int a = BitConverter.ToInt32(sizeRequestsByte, 0);
            byte[] requestsByte = new byte[BitConverter.ToInt32(sizeRequestsByte, 0)];
            bytes = client.Stream.Read(requestsByte, 0, BitConverter.ToInt32(sizeRequestsByte, 0));
            builder.Append(Encoding.UTF8.GetString(requestsByte, 0, bytes));
            if (builder.ToString() == string.Empty)
                client.Close();
            return builder.ToString();
        }
        protected internal void Disconnect()
        {
            tcpListener.Stop(); //остановка сервера

            for (int i = 0; i < users.Count; i++)
            {
                users[i].Close(); //отключение клиента
            }
            Environment.Exit(0); //завершение процесса
        }
    }
}