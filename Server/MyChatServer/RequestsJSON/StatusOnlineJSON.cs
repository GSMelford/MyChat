using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyChatServer.RequestsJSON
{
    class StatusOnlineJSON
    {
        public string Key { get; set; } = "statusonline";
        public List<string> UserList { get; set; }
    }
}
