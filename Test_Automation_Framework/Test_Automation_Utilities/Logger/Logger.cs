using Serilog;

namespace Epam_TestAutomation_Utilities.Logger
{
    public static class Logger
    {
        private static ThreadLocal<List<string>> _log = new ThreadLocal<List<string>>(() => new List<string>());

        public static void Info(string message)
        {
            _log.Value.Add(message);
        }

        public static void InitLogger(string filePath)
        {
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug().WriteTo.File(Path.Combine(filePath, "logs.txt"))
                .CreateLogger();
        }

        public static void FinishTestLog()
        {
            _log.Value.ForEach(x => Log.Logger.Information(x));
            _log.Value.Clear();
        }
    }
}
