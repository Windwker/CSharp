using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = null;
            Console.WriteLine(date.GetValueOrDefault());
            Console.WriteLine(date.HasValue);
           // Console.WriteLine(date.Value);
        }
    }
}
