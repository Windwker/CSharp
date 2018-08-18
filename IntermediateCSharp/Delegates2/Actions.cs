using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates2
{
    public class Actions
    {

        


        public void Run(int number)
        {
            Console.WriteLine("Run" + number);
        }


        public void Walk(int number)
        {
            Console.WriteLine("Walk" + number);
        }

        public void Swim(int number)
        {
            Console.WriteLine("Swim" + number*4);
        }

    }
}
