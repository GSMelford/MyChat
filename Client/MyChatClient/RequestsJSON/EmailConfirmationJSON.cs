﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyChatClient.RequestsJSON
{
    class EmailConfirmationJSON
    {
        public string Key { get; set; } = "emailconfirmation";
        public int Code { get; set; }
    }
}
