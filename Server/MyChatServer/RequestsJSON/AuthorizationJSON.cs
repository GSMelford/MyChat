using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyChatServer.RequestsJSON
{
    class AuthorizationJSON
    {
        public string Key { get; set; } = "authorization";
        public string UsernameOrEmail { get; set; }
        public string Password { get; set; }
    }
}
