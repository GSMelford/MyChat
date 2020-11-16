﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using MyChatServer.RequestsJSON;
using System.IO;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Net.Mail;
using System.Net;

namespace MyChatServer
{
    class DistributorRequests
    {
        ClientObject Client;
        ServerObject Server;
        public DistributorRequests(ClientObject client, ServerObject server)
        {
            this.Client = client;
            this.Server = server;
        }
        public void RequestActivation(string json)
        {
            string request = string.Empty;
            if (json != string.Empty)
            {
                var key = (JObject)JsonConvert.DeserializeObject(json);
                request = key["Key"].Value<string>();
            }
            switch (request)
            {
                case "registration":
                    RegistrationJSON registrationJSON = System.Text.Json.JsonSerializer.Deserialize<RegistrationJSON>(json);
                    Console.WriteLine($"Client ID: {Client.Id}. Registration request.");
                    Console.WriteLine("Requests: " + json);
                    Registration(registrationJSON);
                    break;
                case "emailconfirmation":
                    EmailConfirmationJSON emailConfirmationJSON = System.Text.Json.JsonSerializer.Deserialize<EmailConfirmationJSON>(json);
                    Console.WriteLine($"Client ID: {Client.Id}. Email confirmation request.");
                    Console.WriteLine("Requests: " + json);
                    EmailCodeVerification(emailConfirmationJSON);
                    break;
                case "authorization":
                    AuthorizationJSON authorizationJSON = System.Text.Json.JsonSerializer.Deserialize<AuthorizationJSON>(json);
                    Console.WriteLine($"Client ID: {Client.Id}. Authorization request.");
                    Console.WriteLine("Requests: " + json);
                    Authorization(authorizationJSON);
                    break;
                case "addfriend":
                    AddFriendJSON addFriendJSON = System.Text.Json.JsonSerializer.Deserialize<AddFriendJSON>(json);
                    Console.WriteLine($"Client Username: {Client.Username}. Username: {Client.Username} add friend username:{addFriendJSON.FriendUsername}");
                    Console.WriteLine("Requests: " + json);
                    AddFriend(addFriendJSON);
                    break;
                case "getfriendlist":
                    GetFrindListJSON getFrindListJSON = System.Text.Json.JsonSerializer.Deserialize<GetFrindListJSON>(json);
                    Console.WriteLine($"Client Username: {Client.Username}. FriendList request.");
                    Console.WriteLine("Requests: " + json);
                    GetFriendList(getFrindListJSON);
                    break;
                case "getchat":
                    GetChatJSON getChatJSON = System.Text.Json.JsonSerializer.Deserialize<GetChatJSON>(json);
                    Console.WriteLine($"Client Username: {Client.Username}. GetChat request.");
                    Console.WriteLine("Requests: " + json);
                    GetChat(getChatJSON);
                    break;
                case "sendmessage":
                    SendMessageJSON sendMessageJSON = System.Text.Json.JsonSerializer.Deserialize<SendMessageJSON>(json);
                    Console.WriteLine($"Client Username: {Client.Username}. Send message to user {sendMessageJSON.FriendUsername}");
                    Console.WriteLine("Requests: " + json);
                    SendMessage(sendMessageJSON);
                    break;
                default:
                    break;
            }
        }
        private void Registration(RegistrationJSON registrationJSON)
        {
            bool verification = false;
            string reason = "Сервер разрешает регистрацию.";
            try
            {
                using (StreamReader sr = new StreamReader(ServerDirectory.Database_path, Encoding.UTF8))
                {
                    string line; //Сделать оптимизацию ввиде брейка
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line == string.Empty)
                            continue;
                        if (line == registrationJSON.Username)
                        {
                            reason = "Такой никнейм уже существует.";
                            verification = true;
                            break;
                        }
                        if ((line = sr.ReadLine()) == registrationJSON.Email)
                        {
                            reason = "Такая электроная почта уже зарегистрирована.";
                            verification = true;
                            break;
                        }
                        line = sr.ReadLine();
                    }
                    sr.Close();
                    sr.Dispose();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Failed to open database.");
            }
            if (!verification)
            {
                Console.WriteLine($"Client ID: {Client.Id}. User: {registrationJSON.Username}, Email: {registrationJSON.Email}. Registered on the server.");
                Client.SetDataUser(registrationJSON.Username, registrationJSON.Email, registrationJSON.Password);

                AllowJSON allow = new AllowJSON() { Allow = true, Reason = reason };
                string allowJSON = System.Text.Json.JsonSerializer.Serialize<AllowJSON>(allow);
                Client.SendAnswer(allowJSON);
                SendCodeEmail(registrationJSON.Email, registrationJSON.Username);
            }
            else
            {
                Console.WriteLine($"Client ID: {Client.Id}. User: {registrationJSON.Username}, Email: {registrationJSON.Email}. Can't register.");

                AllowJSON allow = new AllowJSON() { Allow = false, Reason = reason };
                string allowJSON = System.Text.Json.JsonSerializer.Serialize<AllowJSON>(allow);
                Client.SendAnswer(allowJSON);
            }
        }
        private void Authorization(AuthorizationJSON authorizationJSON)
        {
            bool verification = false;
            string reason = "Сервер не разрешает авторизацию.";
            try
            {
                using (StreamReader sr = new StreamReader(ServerDirectory.Database_path, Encoding.UTF8))
                {
                    string line; //Сделать оптимизацию ввиде брейка
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line == string.Empty)
                            continue;
                        string usernameTemp = line;
                        string emailTemp;
                        if (line == authorizationJSON.UsernameOrEmail)
                        {
                            Client.Username = line;
                            emailTemp = sr.ReadLine();
                            if ((line = sr.ReadLine()) == authorizationJSON.Password)
                            {
                                Client.Email = emailTemp;
                                Client.Password = line;
                                verification = true;
                                break;
                            }
                            else
                                reason = "Неправльный пароль.";
                        }
                        else
                        {
                            if ((line = sr.ReadLine()) == authorizationJSON.UsernameOrEmail)
                            {
                                Client.Email = line;
                                if ((line = sr.ReadLine()) == authorizationJSON.Password)
                                {
                                    Client.Username = usernameTemp;
                                    Client.Password = line;
                                    verification = true;
                                    break;
                                }
                                else
                                    reason = "Неправльный пароль.";
                            }
                        }
                        line = sr.ReadLine();
                    }
                    sr.Close();
                    sr.Dispose();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Failed to open database.");
            }

            if (verification)
            {
                AllowJSON allow = new AllowJSON() { Allow = true, Reason = "Сервер разрешает авторизацию." };
                string allowJSON = System.Text.Json.JsonSerializer.Serialize<AllowJSON>(allow);
                Client.SendAnswer(allowJSON);
            }
            else
            {
                AllowJSON allow = new AllowJSON() { Allow = false, Reason = reason };
                string allowJSON = System.Text.Json.JsonSerializer.Serialize<AllowJSON>(allow);
                Client.SendAnswer(allowJSON);
            }
        }
        private void EmailCodeVerification(EmailConfirmationJSON emailConfirmationJSON)
        {
            Console.WriteLine($"Client ID: {Client.Id}. Sent a verification code.");
            if(Client.EmailCode == emailConfirmationJSON.Code)
            {
                Console.WriteLine($"Client ID: {Client.Id}. The confirmation code is correct.");
                try
                {
                    using (StreamWriter sw = new StreamWriter(ServerDirectory.Database_path, true, Encoding.UTF8))
                    {
                        sw.WriteLine(Client.Username);
                        sw.WriteLine(Client.Email);
                        sw.WriteLine(Client.Password);
                        sw.Close();
                        sw.Dispose();
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
                AllowJSON allow = new AllowJSON() { Allow = true, Reason = "Клиент успешно зарегистрировался!" };
                string allowJSON = System.Text.Json.JsonSerializer.Serialize<AllowJSON>(allow);
                Client.SendAnswer(allowJSON);

                ServerDirectory.CreatePersonalCatalog(Client.Username, Client.Email, Client.Password);
            }
            else
            {
                Console.WriteLine($"Client ID: {Client.Id}. The confirmation code is incorrect.");
                AllowJSON allow = new AllowJSON() { Allow = false, Reason = "Неправильный код." };
                string allowJSON = System.Text.Json.JsonSerializer.Serialize<AllowJSON>(allow);
                Client.SendAnswer(allowJSON);
            }
        }
        private void AddFriend(AddFriendJSON addFriendJSON)
        {
            //ServerDirectory.CreateFriendChat(addFriendJSON.FriendUsername, addFriendJSON.chatId);
            if(!ServerDirectory.ExistUser(addFriendJSON.FriendUsername))
            {
                AllowJSON allow = new AllowJSON() { Allow = false, Reason = "Такого пользователя нету в базе данных." };
                string allowJSON = System.Text.Json.JsonSerializer.Serialize<AllowJSON>(allow);
                Client.SendAnswer(allowJSON);
                return;
            } 
            if (ServerDirectory.NewFriend(Client.Username, addFriendJSON.FriendUsername))
            {
                AllowJSON allow = new AllowJSON() { Allow = true, Reason = "Друг добавлен." };
                string allowJSON = System.Text.Json.JsonSerializer.Serialize<AllowJSON>(allow);
                Client.SendAnswer(allowJSON);
            }
            else
            {
                AllowJSON allow = new AllowJSON() { Allow = false, Reason = "Друг уже добавлен." };
                string allowJSON = System.Text.Json.JsonSerializer.Serialize<AllowJSON>(allow);
                Client.SendAnswer(allowJSON);
            }
        }
        private void GetFriendList(GetFrindListJSON getFrindListJSON)
        {
            getFrindListJSON.FriendList = ServerDirectory.FriendList(Client.Username);
            string getFrindList = System.Text.Json.JsonSerializer.Serialize<GetFrindListJSON>(getFrindListJSON);
            Client.SendAnswer(getFrindList);
        }
        private void GetChat(GetChatJSON getChatJSON)
        {
            getChatJSON.Chat = ServerDirectory.FindChat(Client.Username, getChatJSON.FriendUsername);
            string getChat = System.Text.Json.JsonSerializer.Serialize<GetChatJSON>(getChatJSON);
            Client.SendAnswer(getChat);
        }
        private void SendMessage(SendMessageJSON sendMessageJSON)
        {
            ServerDirectory.SaveMessage(Client.Username, sendMessageJSON.FriendUsername, sendMessageJSON.Message);
            string friendUsername = sendMessageJSON.FriendUsername;
            sendMessageJSON.FriendUsername = Client.Username;
            string answer = System.Text.Json.JsonSerializer.Serialize<SendMessageJSON>(sendMessageJSON);
            Server.SendMessage(answer, friendUsername);
        }
        private void SendCodeEmail(string email, string username)
        {
            Random rand = new Random();
            var fromAddress = new MailAddress("dut.pd1.hw2019@gmail.com", "MyChat");
            var toAddress = new MailAddress(email, username);
            const string fromPassword = "jhd32^#21Jshdlf2#1";
            const string subject = "Потверждение регистрации в MyChat.";
            Client.EmailCode = rand.Next(10000, 90000);
            string body = "Hello! I see you used my messenger ?? \nWow! \nAwesome! \n\n\n\tHere is your verification code: " + Client.EmailCode + "\n\n\n\tAll the best, MyChat.";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                Timeout = 20000
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
    }
}