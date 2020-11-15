using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyChatClient.RequestsJSON
{
    class AddFriendJSON
    {
        public string Key { get; set; } = "addfriend";
        public string FriendUsername { get; set; }
    }
}
