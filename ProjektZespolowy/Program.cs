using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace ProjektZespolowy
{
    class Program
    {

        public static HttpClient Api { get; set; }
        public static void InitalizeClien()
        {
            Api = new HttpClient();
            Api.BaseAddress = new Uri("http://localhost:48398/api/");
            Api.DefaultRequestHeaders.Accept.Clear();
            Api.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
