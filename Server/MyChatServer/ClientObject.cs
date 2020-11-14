﻿using System;
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
        protected internal NetworkStream Stream { get; private set; }
        ServerObject serverObject;
        TcpClient tcpClient;
        
        public ClientObject(TcpClient tcpClient, ServerObject serverObject)
        {
            Id = Guid.NewGuid().ToString();
            this.tcpClient = tcpClient;
            this.serverObject = serverObject;
            serverObject.AddConnection(this);
            Console.WriteLine("Unknown connection. Issued ID:" + Id);
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
                Stream = tcpClient.GetStream();
                DistributorRequests distributorRequests = new DistributorRequests(this);
                while (true)
                {
                    distributorRequests.RequestActivation(serverObject.GetMessage(Id));
                }
            }
            catch (Exception)
            {
                Console.WriteLine($"The connection with the user under id was lost:{Id}");
            }
            finally
            {
                serverObject.RemoveConnection(this.Id);
                Close();
            }
        }
        protected internal void SendMessage(string json)
        {
            byte[] data = Encoding.UTF8.GetBytes(json);

            Int32 sizeRequests = data.Length;
            byte[] sizeRequestsByte = BitConverter.GetBytes(sizeRequests);

            Stream.Write(sizeRequestsByte, 0, sizeRequestsByte.Length);
            Stream.Write(data, 0, data.Length);
        }
        protected internal void Close()
        {
            if (Stream != null)
                Stream.Close();
            if (tcpClient != null)
                tcpClient.Close();
        }
    }
}