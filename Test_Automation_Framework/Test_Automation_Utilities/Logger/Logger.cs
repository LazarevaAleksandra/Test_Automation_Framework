using Serilog;

namespace Epam_TestAutomation_Utilities.Logger
{
    public static class Logger
    {
        public static ThreadLocal<List<string>> _logger = 
            new ThreadLocal<List<string>>(() => new List<string>());

        public static void Info(string message)
        {
            _logger.Value.Add(message);
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
            _logger.Value.ForEach(x => Log.Logger.Information(x));
            _logger.Value.Clear();
        }
    }
}
