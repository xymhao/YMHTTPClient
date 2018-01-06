using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace YMHTTPClient
{
    public static class YMHttpClient
    {
        public static void Post()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            var content = new FormUrlEncodedContent(new Dictionary<string, string>()
            {
               {"ak", "65fc7ca4fc441d26f71bf3d691b278c2"},
               {"deviceId", "537eb34be4b022b7fbe19471"}
            });
            client.PostAsync("", content);
        }
    }
}
