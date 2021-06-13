using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ProjektZespolowy.Klasy
{
    class RegisterRespons
    {
        [JsonProperty("data")]
        public string Data { get; set; }
        [JsonProperty("succeeded")]
        public bool Succeeded { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("errors")]
        public List<string> Errors { get; set; }

    }
}
