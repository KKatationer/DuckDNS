namespace DuckDns.Helper
{
    internal class LogHelper
    {
        public static void Info(string message)
        {
            using var fs = new FileStream("info.log", FileMode.Append, FileAccess.Write, FileShare.Read);
            using var sw = new StreamWriter(fs);
            sw.Write($"{DateTime.Now} {message}");
            sw.Write(Environment.NewLine);
            sw.Flush();
        }

        public static void Error(string message, Exception ex = null)
        {
            using var fs = new FileStream("error.log", FileMode.Append, FileAccess.Write, FileShare.Read);
            using var sw = new StreamWriter(fs);
            if (ex != null)
                sw.Write($"{DateTime.Now} {message} {ex.Message}");
            else
                sw.Write($"{DateTime.Now} {message}");
            sw.Write(Environment.NewLine);
            sw.Flush();
        }
    }
}
