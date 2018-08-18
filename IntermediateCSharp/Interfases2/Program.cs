using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfases2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var dbMigrator = new DbMigrator(new FileLogger("C:\\Users\\Javi\\Documents\\log.txt"));
                dbMigrator.Migrate();
            }
            catch (System.UnauthorizedAccessException)
            {

                System.Console.WriteLine("Unauthorized access"); ;
            }
            

        }
    }
}
