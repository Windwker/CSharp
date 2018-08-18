using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates2
{
    //public delegate void Delegado(int number);
    //Action<int>;

    class Program
    {
        static void Main(string[] args)
        {
            Actions actions = new Actions();
            Action<int> delegado;
           delegado = actions.Walk;
            delegado += actions.Run;
            delegado += actions.Swim;
            delegado += sleepAction;
            delegado(20);
            


        }

        static void sleepAction(int number)
        {
            Console.WriteLine("Sleeping zzz" + number);
        }
    }
}
