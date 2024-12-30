using Microsoft.Extensions.Logging;

namespace LoggingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ILoggerFactory factory = LoggerFactory.Create(
                builder =>
                {
                    builder.AddConsole();
                    builder.SetMinimumLevel(LogLevel.None);
                }
            );
            ILogger logger = factory.CreateLogger("Program1");

            logger.LogTrace("LogTrace");
            logger.LogDebug("LogDebug");
            logger.LogInformation("LogInformation");
            logger.LogWarning("LogWarning");
            logger.LogError("LogError");
            logger.LogCritical("LogCritical");

            if (logger.IsEnabled(LogLevel.Debug))
            {
                logger.LogDebug("LogDebug:enable");
            }


        }
    }
}
