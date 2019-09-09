using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Beux.Models
{
    public class Chat
    {
        [JsonProperty("username")]
        public string UserName
        {
            get;
            set;
        }
        [JsonProperty  ("usermessage")]
        public string UserMessage
        {
            get;
            set;
        }
    }
}
