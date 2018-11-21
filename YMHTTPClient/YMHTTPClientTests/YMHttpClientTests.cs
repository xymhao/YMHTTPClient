using Microsoft.VisualStudio.TestTools.UnitTesting;
using YMHTTPClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace YMHTTPClient.Tests
{
    [TestClass()]
    public class YMHttpClientTests
    {
        [TestMethod()]
        public void PostAsyncTest()
        {
            var json = YMHttpClient.PostAsync<string>(@"https://www.ietf.org/rfc/rfc2616.txt", p =>
            {
                Console.WriteLine(p);
            });
            var str = json.Result;
            Console.Write("123");
            //Assert.Fail();
        }
    }
}