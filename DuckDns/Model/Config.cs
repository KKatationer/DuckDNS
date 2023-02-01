using System.Configuration;

namespace DuckDns.Model
{
    internal class Config
    {
        private static string _domain = string.Empty;
        private static string _token = string.Empty;

        public static string Domain
        {
            get
            {
                _domain = ConfigurationManager.AppSettings["Domain"];
                if (string.IsNullOrEmpty(_domain))
                    throw new Exception("未填写域名");
                else
                    return _domain;
            }
        }

        public static string Token
        {
            get 
            {
                _token = ConfigurationManager.AppSettings["Token"];
                if (string.IsNullOrEmpty(_token))
                    throw new Exception("未填写Token");
                else
                    return _token; 
            }
        }
    }
}
