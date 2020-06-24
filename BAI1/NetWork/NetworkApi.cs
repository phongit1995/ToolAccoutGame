using BAI1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BAI1.NetWork
{
    class NetworkApi
    {
        public NetworkApi()
        {
            this.client = new HttpClient();
            this.AddHeaders();
        }
        public void AddHeaders()
        {
            this.client.DefaultRequestHeaders.TryAddWithoutValidation("Client-OperatingSystem", "Windows");
            this.client.DefaultRequestHeaders.TryAddWithoutValidation("Client-DeviceID", StringUtils.GetRandomSerialString(32));
            this.client.DefaultRequestHeaders.TryAddWithoutValidation("Client-UserAgent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/80.0.3984.0 Safari/537.36");
            this.client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/80.0.3984.0 Safari/537.36");
            this.client.DefaultRequestHeaders.TryAddWithoutValidation("Client-Browser", "Chrome 80");
        }
        public HttpClient client;
    }
}
