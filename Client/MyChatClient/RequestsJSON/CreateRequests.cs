using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyChatClient.RequestsJSON
{
    class CreateRequests
    {
        ClientLogic Client;
        public CreateRequests(ClientLogic client)
        {
            this.Client = client;
        }

        public bool Registration()
        {
            try
            {
                //Создание JSON файла с данными пользователя
                RegistrationJSON registrationJSON = new RegistrationJSON { Username = Client.Username, Email = Client.Email, Password = Client.Password };
                string requestJSON = JsonSerializer.Serialize<RegistrationJSON>(registrationJSON);
                Client.SendMessage(requestJSON);
                return AllowServer(Client.GetMessage());

            }
            catch (Exception)
            {
                MessageBox.Show("Подключение к серверу отсутствует.");
            }
            return false;
        }

        public bool AllowServer(string json)
        {
            AllowJSON allowJSON = JsonSerializer.Deserialize<AllowJSON>(json);
            MessageBox.Show(allowJSON.Reason);
            return allowJSON.Allow;
        }

        public bool EmailCheack(int code)
        {
            try
            {
                EmailCheackJSON emailCheackJSON = new EmailCheackJSON { Code = code };
                string requestJSON2 = JsonSerializer.Serialize<EmailCheackJSON>(emailCheackJSON);
                Client.SendMessage(requestJSON2);
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            
            return AllowServer(Client.GetMessage());
        }
    }
}
