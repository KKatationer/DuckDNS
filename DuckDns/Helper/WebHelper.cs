namespace DuckDns.Helper
{
    internal class WebHelper
    {
        public static void DDNS(string url)
        {
            try
            {
                var client = new HttpClient();
                var response = client.GetAsync(url).Result;
                string result;
                if (response.IsSuccessStatusCode)
                {
                    result = response.Content.ReadAsStringAsync().Result;
                    LogHelper.Info(result);
                }
                else
                {
                    result = $"更新失败，代码{response.StatusCode}";
                    LogHelper.Error(result);
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error("访问接口失败", ex);
            }
        }
    }
}
