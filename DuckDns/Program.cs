using DuckDns.Helper;
using DuckDns.Model;

var ip = new IPHelper();
try
{
    ip.GetIP();
    var v4 = ip.IPv4;
    var v6 = string.Empty;
    if (!string.IsNullOrEmpty(ip.IPv6))
        v6 += $"&ipv6={ip.IPv6}";

    var domain = Config.Domain;
    var token = Config.Token;
    
    string url = @$"https://www.duckdns.org/update?domains={domain}&token={token}&verbose=true&ip={v4}{v6}";
    WebHelper.DDNS(url);
}
catch(Exception ex)
{
    LogHelper.Error("错误", ex);
}