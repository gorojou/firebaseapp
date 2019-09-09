using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Beux.Models
{

    public class Room
    {
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
        [JsonProperty("key")]
        public string Key
        {
            get;
            set;
        }
    }
}
