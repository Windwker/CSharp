using System;

namespace Interfases2
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            //Console.WriteLine("Migration started at {0}",DateTime.Now);
            //Console.WriteLine("Migration finished at {0}",DateTime.Now);
            _logger.Loginfo("Migration started at {0}" + DateTime.Now);
            _logger.Loginfo("Migration finished at {0}"+ DateTime.Now);
        }
    }
}
