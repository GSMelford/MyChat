namespace MyChatClient
{
    public class SendMessageJSON
    {
        public string Key { get; set; } = "sendmessage";
        public string FriendUsername { get; set; }
        public string Time { get; set; }
        public string MyUsername { get; set; }
        public string Message { get; set; }
    }
}
