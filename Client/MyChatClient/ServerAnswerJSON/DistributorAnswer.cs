using MyChatClient.RequestsJSON;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace MyChatClient.ServerAnswerJSON
{
    class DistributorAnswer
    {
        public DistributorAnswer(MessengerForm messengerForm)
        {
            MessengerForm = messengerForm;
        }

        public MessengerForm MessengerForm { get; }

        public void AnswerActivation(string json)
        {
            string answer = string.Empty;
            if (json != string.Empty)
            {
                var key = (JObject)JsonConvert.DeserializeObject(json);
                answer = key["Key"].Value<string>();
            }
            switch (answer)
            {
                case "sendmessage":
                    SendMessageJSON sendMessageJSON = System.Text.Json.JsonSerializer.Deserialize<SendMessageJSON>(json);
                    AddChatMessage(sendMessageJSON);
                    break;
                case "statusonline":
                    StatusOnlineJSON statusOnlineJSON = System.Text.Json.JsonSerializer.Deserialize<StatusOnlineJSON>(json);
                    StartRefreshUsersOnline(statusOnlineJSON);
                    break;
                default:
                    MessageBox.Show("Server send string.Empty Answer. Stream 2.");
                    break;
            }
        }
        private void AddChatMessage(SendMessageJSON sendMessageJSON)
        {
            if (MessengerForm.GetFriendUsername().Text == sendMessageJSON.FriendUsername)
            {
                MessengerForm.GetChat().Text += sendMessageJSON.Message;
                MessengerForm.GetChat().Text += '\r';
                MessengerForm.GetChat().Text += '\n';
            }
            else
            {
                foreach (var buttonPanel in MessengerForm.GetPanelFriendList().Controls)
                {
                    Button button = (Button)buttonPanel;
                    if(button.Text == sendMessageJSON.FriendUsername)
                    {
                        button.ForeColor = System.Drawing.Color.LightYellow;
                    }
                }
            }
        }
        private void StartRefreshUsersOnline(StatusOnlineJSON statusOnlineJSON)
        {
            MessengerForm.RefreshFriendsToList(CreateRequests.GetFriendList());
            MessengerForm.RefreshUsersStatus(statusOnlineJSON.UserList);
        }
    }
}