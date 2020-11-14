using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyChatClient.RequestsJSON
{
    class AllowJSON
    {
        public string Key { get; set; } = "allow";
        public bool Allow { get; set; }
        public string Reason { get; set; }
    }
}
