using MyChatClient.ServerAnswerJSON;
using System;
using System.Collections.Generic;
using System.Text.Json;
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
                if (!ClientLogic.ConnectToServer())
                {
                    MessageBox.Show("Сервер не відповідає.");
                    return false;
                }
                else
                {
                    RegistrationJSON registrationJSON = new RegistrationJSON { Username = username, Email = email, Password = password };
                    string requestJSON = JsonSerializer.Serialize<RegistrationJSON>(registrationJSON);
                    ClientLogic.SendMessage(requestJSON);
                    return AllowServer(ClientLogic.GetAnswer());
                }
            }
        }
        public static bool EmailConfirmation(int code)
        {
            try
            {
                EmailConfirmationJSON emailConfirmationJSON = new EmailConfirmationJSON { Code = code };
                string requestJSON2 = JsonSerializer.Serialize<EmailConfirmationJSON>(emailConfirmationJSON);
                ClientLogic.SendMessage(requestJSON2);

                return AllowServer(ClientLogic.GetAnswer());
            }
            catch (Exception)
            {
                MessageBox.Show("EmailConfirmation() Error.");
            }
            return false;
        }
        public static bool Authorization(string usernameOrEmail, string password)
        {
            try
            {
                AuthorizationJSON authorizationJSON = new AuthorizationJSON { UsernameOrEmail = usernameOrEmail, Password = password };
                string requestJSON = JsonSerializer.Serialize<AuthorizationJSON>(authorizationJSON);
                ClientLogic.SendMessage(requestJSON);
            }
            catch (Exception)
            {
                if(!ClientLogic.ConnectToServer())
                {
                    MessageBox.Show("Сервер не відповідає.");
                    return false;
                }
                else
                {
                    AuthorizationJSON authorizationJSON = new AuthorizationJSON { UsernameOrEmail = usernameOrEmail, Password = password };
                    string requestJSON = JsonSerializer.Serialize<AuthorizationJSON>(authorizationJSON);
                    ClientLogic.SendMessage(requestJSON);
                }
            }
            string answer = ClientLogic.GetAnswer();
            if (string.IsNullOrEmpty(answer))
            {
                MessageBox.Show("Сервер не відповідає.");
                return false;
            }
            AllowAuthorizationJSON allowAuthorizationJSON = JsonSerializer.Deserialize<AllowAuthorizationJSON>(answer);
            if(allowAuthorizationJSON.Allow)
            {
                ClientLogic.Username = allowAuthorizationJSON.Username;
                ClientLogic.Email = allowAuthorizationJSON.Email;
                ClientLogic.Password = allowAuthorizationJSON.Password;
                ClientDirectory.SaveAuthorization();
                return true;
            }
            else
            {
                MessageBox.Show(allowAuthorizationJSON.Reason);
                return false;
            }

        }
        public static bool AddFriend(string friendUsername)
        {
            try
            {
                AddFriendJSON addFriendJSON = new AddFriendJSON { FriendUsername = friendUsername };
                string requestJSON = JsonSerializer.Serialize<AddFriendJSON>(addFriendJSON);
                ClientLogic.SendMessage(requestJSON);
                return AllowServer(ClientLogic.GetAnswer());
            }
            catch (Exception)
            {
                MessageBox.Show("AddFriend() Error.");
            }
            return false;
        }
        public static bool RemoveFriend(string friendUsername)
        {
            try
            {
                AddFriendJSON addFriendJSON = new AddFriendJSON { Key = "removefriend", FriendUsername = friendUsername };
                string requestJSON = JsonSerializer.Serialize<AddFriendJSON>(addFriendJSON);
                ClientLogic.SendMessage(requestJSON);
                return AllowServer(ClientLogic.GetAnswer());
            }
            catch (Exception)
            {
                MessageBox.Show("RemoveFriend() Error.");
            }
            return false;
        }
        public static List<string> GetFriendList()
        {
            try
            {
                GetFrindListJSON getFrindListJSON = new GetFrindListJSON();
                string requestJSON = JsonSerializer.Serialize<GetFrindListJSON>(getFrindListJSON);
                ClientLogic.SendMessage(requestJSON);
                getFrindListJSON = JsonSerializer.Deserialize<GetFrindListJSON>(ClientLogic.GetAnswer());
                return getFrindListJSON.FriendList;
            }
            catch (Exception)
            {
                //MessageBox.Show("GetFriendList() Error.");
            }
            return null;
        }
        public static string GetChat(string friendUsername)
        {
            try
            {
                GetChatJSON getChatJSON = new GetChatJSON { FriendUsername = friendUsername };
                string requestJSON = JsonSerializer.Serialize<GetChatJSON>(getChatJSON);
                ClientLogic.SendMessage(requestJSON);
                getChatJSON = JsonSerializer.Deserialize<GetChatJSON>(ClientLogic.GetAnswer());
                return getChatJSON.Chat;
            }
            catch (Exception)
            {
                MessageBox.Show("GetChat() Error.");
            }
            return string.Empty;
        }
        public static void SendMessage(string friendUsername, string message)
        {
            try
            {
                SendMessageJSON sendMessageJSON = new SendMessageJSON { FriendUsername = friendUsername, Message = message, MyUsername = ClientLogic.Username, Time = DateTime.Now.ToString() };
                string requestJSON = JsonSerializer.Serialize<SendMessageJSON>(sendMessageJSON);
                ClientLogic.SendMessage(requestJSON);
            }
            catch (Exception)
            {
                MessageBox.Show("SendMessage() Error.");
            }
        }
        public static List<string> RefreshUsersOnline()
        {
            try
            {
                StatusOnlineJSON statusOnlineJSON = new StatusOnlineJSON();
                string requestJSON = JsonSerializer.Serialize<StatusOnlineJSON>(statusOnlineJSON);
                ClientLogic.SendMessage(requestJSON);
                statusOnlineJSON = JsonSerializer.Deserialize<StatusOnlineJSON>(ClientLogic.GetAnswer());
                return statusOnlineJSON.UserList;
            }
            catch (Exception)
            {
                MessageBox.Show("RefreshUsersOnline() Error.");
            }
            return null;
        }
        public static bool AllowServer(string json)
        {
            if(json != string.Empty)
            {
                try
                {
                    AllowJSON allowJSON = JsonSerializer.Deserialize<AllowJSON>(json);
                    if (!allowJSON.Allow)
                        MessageBox.Show(allowJSON.Reason);
                    return allowJSON.Allow;
                }
                catch (Exception)
                {
                    MessageBox.Show("AllowServer() Error.");
                }
                return false;
            }
            else
            {
                MessageBox.Show("Сервер не дав відповідь. Перевірте підключення до інтернету.");
                return false;
            }
        }
    }
}