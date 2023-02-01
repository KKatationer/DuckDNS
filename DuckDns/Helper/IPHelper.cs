using System.Net;
using System.Net.Sockets;

namespace DuckDns.Helper
{
    internal class IPHelper
    {
        public string HostName { get; private set; }

        public string IPv4 { get; private set; }

        public string IPv6 { get; private set; }

        public void GetIP()
        {
            var ips = GetAddresses();
            if (ips == null)
                return;

            var ipv4 = ips.Where(x => x.AddressFamily == AddressFamily.InterNetwork);
            var ipv6 = ips.Where(x => x.AddressFamily == AddressFamily.InterNetworkV6 && !x.IsIPv6LinkLocal && !x.ToString().StartsWith('f'));
            if (ipv4.Any()) IPv4 = ipv4.First().ToString();
            if (ipv6.Any()) IPv6 = ipv6.First().ToString();
        }

        private IPAddress[] GetAddresses()
        {
            try
            {
                HostName = Dns.GetHostName();
                var ips = Dns.GetHostAddresses(HostName);
                return ips;
            }
            catch (Exception ex)
            {
                LogHelper.Error($"获取IP地址失败", ex);
                return null;
            }
        }  
    }
}
