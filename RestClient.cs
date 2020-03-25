using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace CFBRisk
{
    public class RestClient
    {
        private const string BaseURL = "https://collegefootballrisk.com/api";
        private static HttpClient client = new HttpClient();

        public HttpResponseMessage GetAsync(string path)
        {
            return client.GetAsync(BaseURL + path).Result;
        }
    }
}
