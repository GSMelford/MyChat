﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyChatServer.RequestsJSON
{
    public class SendMessageJSON
    {
        public string Key { get; set; } = "sendmessage";
        public string FriendUsername { get; set; }
        public string Message { get; set; }
    }
}
