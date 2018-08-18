using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(square(5));

            Func<int, int> square = number => number*number;
            Console.WriteLine(square(20));
            
        }

        static int square(int number)
        {
            return number * number;
        }
    }
}
