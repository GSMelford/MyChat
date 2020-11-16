using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyChatClient.RequestsJSON
{
    static class CreateRequests
    {
        public static bool Registration(string username, string email, string password)
        {
            try
            {
                RegistrationJSON registrationJSON = new RegistrationJSON { Username = username, Email = email, Password = password };
                string requestJSON = JsonSerializer.Serialize<RegistrationJSON>(registrationJSON);
                ClientLogic.SendMessage(requestJSON);
                return AllowServer(ClientLogic.GetAnswer());
            }
            catch (Exception)
            {
                MessageBox.Show("Подключение к серверу отсутствует.");
            }
            return false;
        }
        public static bool EmailConfirmation(int code)
        {
            EmailConfirmationJSON emailConfirmationJSON = new EmailConfirmationJSON { Code = code };
            string requestJSON2 = JsonSerializer.Serialize<EmailConfirmationJSON>(emailConfirmationJSON);
            ClientLogic.SendMessage(requestJSON2);

            return AllowServer(ClientLogic.GetAnswer());
        }
        public static bool Authorization(string usernameOrEmail, string password)
        {
            AuthorizationJSON authorizationJSON = new AuthorizationJSON { UsernameOrEmail = usernameOrEmail, Password = password };
            string requestJSON = JsonSerializer.Serialize<AuthorizationJSON>(authorizationJSON);
            ClientLogic.SendMessage(requestJSON);
            return AllowServer(ClientLogic.GetAnswer());
        }
        public static bool AddFriend(string friendUsername)
        {
            AddFriendJSON addFriendJSON = new AddFriendJSON { FriendUsername = friendUsername };
            string requestJSON = JsonSerializer.Serialize<AddFriendJSON>(addFriendJSON);
            ClientLogic.SendMessage(requestJSON);
            return AllowServer(ClientLogic.GetAnswer());
        }
        public static List<string> GetFriendList()
        {
            GetFrindListJSON getFrindListJSON = new GetFrindListJSON();
            string requestJSON = JsonSerializer.Serialize<GetFrindListJSON>(getFrindListJSON);
            ClientLogic.SendMessage(requestJSON);
            getFrindListJSON = JsonSerializer.Deserialize<GetFrindListJSON>(ClientLogic.GetAnswer());
            return getFrindListJSON.FriendList;
        }
        public static string GetChat(string friendUsername)
        {
            ClientLogic.FriendUserNow = friendUsername;
            GetChatJSON getChatJSON = new GetChatJSON { FriendUsername = friendUsername };
            string requestJSON = JsonSerializer.Serialize<GetChatJSON>(getChatJSON);
            ClientLogic.SendMessage(requestJSON);
            getChatJSON = JsonSerializer.Deserialize<GetChatJSON>(ClientLogic.GetAnswer());
            return getChatJSON.Chat;
        }
        public static void SendMessage(string friendUsername, string message)
        {
            SendMessageJSON sendMessageJSON = new SendMessageJSON { FriendUsername = friendUsername, Message = message };
            string requestJSON = JsonSerializer.Serialize<SendMessageJSON>(sendMessageJSON);
            ClientLogic.SendMessage(requestJSON);
        }
        public static bool AllowServer(string json)
        {
            AllowJSON allowJSON = JsonSerializer.Deserialize<AllowJSON>(json);
            if(!allowJSON.Allow)
                MessageBox.Show(allowJSON.Reason);
            return allowJSON.Allow;
        }
    }
}