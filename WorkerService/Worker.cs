using Domain.Interfaces.Application;

namespace WorkerService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IServiceTransaction _serviceTransaction;

        public Worker(ILogger<Worker> logger, IServiceTransaction serviceTransaction)
        {
            _logger = logger;
            _serviceTransaction = serviceTransaction;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            int position = 1;

            while (!stoppingToken.IsCancellationRequested)
            {
                await _serviceTransaction.Create();
                Console.WriteLine($"This is the {position} to finalize.");
                if (_logger.IsEnabled(LogLevel.Information))
                {
                    _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                }

                position++;
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
