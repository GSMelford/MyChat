using System;
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
        public DistributorRequests(ClientObject client)
        {
            this.Client = client;
        }

        public void RequestActivation(string json)
        {
            Console.WriteLine("Requests: " + json);
            var key = (JObject)JsonConvert.DeserializeObject(json);
            string request = key["Key"].Value<string>();
            switch (request)
            {
                case "registration":
                    RegistrationJSON registrationJSON = System.Text.Json.JsonSerializer.Deserialize<RegistrationJSON>(json);
                    Console.WriteLine("Registration request from ID:" + Client.Id);
                    Registration(registrationJSON);
                    break;
                case "emailverification":
                    EmailCheackJSON emailCheackJSON = System.Text.Json.JsonSerializer.Deserialize<EmailCheackJSON>(json);
                    Console.WriteLine("Email verification request from ID:" + Client.Id);
                    EmailCodeVerification(emailCheackJSON);
                    break;
                default:
                    break;
            }
        }

        private void Registration(RegistrationJSON registrationJSON)
        {
            bool verification = false;
            string reason = string.Empty;
            try
            {
                using (StreamReader sr = new StreamReader(ServerObject.Database_path, Encoding.UTF8))
                {
                    string line; //Сделать оптимизацию ввиде брейка
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line == registrationJSON.Username)
                        {
                            reason = "Такой ник нейм уже существует.";
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
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Failed to open database.");
            }
            if (!verification)
            {
                Console.WriteLine($"Attempt to register. User: {registrationJSON.Username}, Email: {registrationJSON.Email}.");
                Client.SetDataUser(registrationJSON.Username, registrationJSON.Email, registrationJSON.Password);

                AllowJSON allow = new AllowJSON() { Allow = true, Reason = reason };
                string allowJSON = System.Text.Json.JsonSerializer.Serialize<AllowJSON>(allow);
                Client.SendMessage(allowJSON);
                SendCodeEmail(registrationJSON.Email, registrationJSON.Username);
            }
            else
            {
                Console.WriteLine("Attempt to register. Error. Such a user already exists in the database.");

                AllowJSON allow = new AllowJSON() { Allow = false, Reason = reason };
                string allowJSON = System.Text.Json.JsonSerializer.Serialize<AllowJSON>(allow);
                Client.SendMessage(allowJSON);
            }
        }

        public void EmailCodeVerification(EmailCheackJSON emailCheackJSON)
        {
            Console.WriteLine($"Client with ID:{Client.Id} . Sent a verification code.");
            if(Client.EmailCode == emailCheackJSON.Code)
            {
                Console.WriteLine($"Client with ID:{Client.Id} . The confirmation code is correct.");
                using (StreamWriter sw = new StreamWriter(ServerObject.Database_path, true, Encoding.UTF8))
                {
                    sw.WriteLine(Client.Username);
                    sw.WriteLine(Client.Email);
                    sw.WriteLine(Client.Password);
                }
                AllowJSON allow = new AllowJSON() { Allow = true, Reason = "Клиент успешно зарегистрировался!" };
                string allowJSON = System.Text.Json.JsonSerializer.Serialize<AllowJSON>(allow);
                Client.SendMessage(allowJSON);
            }
            else
            {
                Console.WriteLine($"Client with ID:{Client.Id} . The confirmation code is incorrect.");
                AllowJSON allow = new AllowJSON() { Allow = false, Reason = "Неправильный код." };
                string allowJSON = System.Text.Json.JsonSerializer.Serialize<AllowJSON>(allow);
                Client.SendMessage(allowJSON);
            }
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