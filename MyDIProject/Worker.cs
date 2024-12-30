namespace MyDIProject;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;
    private readonly IMessageWriter _messageWriter;
    private readonly IServiceProvider services;

    public Worker(ILogger<Worker> logger, IMessageWriter messageWriter, IServiceProvider services)
    {
        _logger = logger;
        _messageWriter = messageWriter;
        this.services = services;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var m1 = services.GetService<IMessageWriter>();
        
        while (!stoppingToken.IsCancellationRequested)
        {
            _messageWriter.Write($"Current time: {DateTime.Now}");
;
            if (_logger.IsEnabled(LogLevel.Information))
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
            }
            await Task.Delay(5000, stoppingToken);
        }
    }
}
