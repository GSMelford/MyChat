using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyChatClient.RequestsJSON
{
    class GetFrindListJSON
    {
        public string Key { get; set; } = "getfriendlist";
        public List<string> FriendList { get; set; }
    }
}
