﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyChatClient.RequestsJSON
{
    class EmailCheackJSON
    {
        public string Key { get; set; } = "emailverification";
        public int Code { get; set; }
    }
}
