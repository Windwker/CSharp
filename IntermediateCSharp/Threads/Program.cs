using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(Write));
            var state = t.ThreadState.ToString();
            Console.WriteLine(state);
            t.Start();
            t.Suspend();
            state = t.ThreadState.ToString();
            Console.WriteLine(state);

            t.Resume();
            state = t.ThreadState.ToString();
            Console.WriteLine(state);
            var current = Thread.CurrentThread;
            Console.WriteLine(current.ToString());
        }

        static void Write()
        {
            Console.WriteLine("Thread" );
            var data = Thread.;
            var current = Thread.CurrentThread.ToString();
            Console.WriteLine(current);
            //Thread.Sleep(5000);
        }
    }
}
