using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace YMHTTPClient
{
    public static class YMHttpClient
    {
        public static void Post(string uri, Action<string> act)
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

        public async static Task<string> PostAsync<T>(string uri, Action<string> act)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("text/plain"));

            var task = client.GetAsync(uri);
            var response = await task;
            var content = response.Content;
            var json  = await content.ReadAsStringAsync();
            return json;
        }

        //public static void HTTPClientHandle()
        //{
        //    var client = new HttpClient((HttpMessageHandler)new HttpClientHandler());
        //    //HttpClientHandler 内部使用HttpWebRequest HttpWebResponse

        //    //哭护短缓存、管道和客户端验证
        //    var handler = new WebPageTraceListener
        //    {
        //        AuthenticationLevel = System.Net.Security.AuthenticationLevel.MutualAuthRequired,
        //        CachePolicy = new System.Net.Cache.RequestCachePolicy (System.Net.Cache.RequestCacheLevel.Default)
        //    };
        //    var httpClient = new HttpClient(handler);

        //    //
        //}

    }
}
