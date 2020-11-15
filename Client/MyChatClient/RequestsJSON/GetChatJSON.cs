using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyChatClient.RequestsJSON
{
    class GetChatJSON
    {
        public string Key { get; set; } = "getchat";
        public string FriendUsername { get; set; }
        public string Chat { get; set; }
    }
}
