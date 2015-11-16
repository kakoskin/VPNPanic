using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPNPanic
{
    public class IPDetector
    {
        public async Task<System.Net.IPAddress> DetectPublicIP(int timeoutMs)
        {
            string url = $"https://api.ipify.org?ticks={System.DateTime.Now.Ticks}";
            var client = new System.Net.Http.HttpClient();
            client.Timeout = TimeSpan.FromMilliseconds(timeoutMs);
            var response = await client.GetStringAsync(url);
            return System.Net.IPAddress.Parse(response);
        }

        public static bool IsInRange(System.Net.IPAddress address, byte?[] range)
        {
            if(address.AddressFamily != System.Net.Sockets.AddressFamily.InterNetwork)
            {
                return false;
            }
            for(int i = 0; i < range.Length; i++)
            {
                if(range[i].HasValue)
                {
                    if (address.GetAddressBytes()[i] != range[i].Value)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

    }
}
