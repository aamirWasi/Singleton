using System;

namespace OOD.SingletonApplicationLog
{
    public class DbMigrator
    {
        private readonly IConsoleLogger _logger;

        public DbMigrator(IConsoleLogger logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
        public void Migrate()
        {
            _logger.LogInfoMessage($"Migrating started at : {DateTimeOffset.UtcNow}");
            _logger.LogErrorMessage($"Migrating Finished at : {DateTimeOffset.UtcNow}");
        }
    }
}
