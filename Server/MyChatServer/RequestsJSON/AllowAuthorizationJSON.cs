using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyChatServer.RequestsJSON
{
    class AllowAuthorizationJSON
    {
        public string Key { get; set; } = "allowauthorization";
        public bool Allow { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Reason { get; set; }
    }
}
