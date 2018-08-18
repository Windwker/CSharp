using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var i = 1;
                var b = 0;
                var c = i / b;
            }
            catch (Exception e)
            {

                Console.WriteLine("Error:" + e.Message);
            }
            
        }
    }
}
