using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                default:
                    break;
            }
        }
        private void AddChatMessage(SendMessageJSON sendMessageJSON)
        {
            if (MessengerForm.GetFriendUsername().Text == sendMessageJSON.FriendUsername)
            {
                MessengerForm.GetChat().Text += sendMessageJSON.Message + '\n' + '\r';
            }
        }
    }
}