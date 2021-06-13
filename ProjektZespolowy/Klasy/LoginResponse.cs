using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ProjektZespolowy.Klasy
{
   public class LoginResponse
    {
        [JsonProperty("token")]
        public  string Token { get; set; }
        [JsonProperty("expiration")]
        public  string Expiration { get; set; }
    }
}
