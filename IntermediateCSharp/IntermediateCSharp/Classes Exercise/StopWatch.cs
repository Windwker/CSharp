using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateCSharp.Classes_Exercise
{
    public class StopWatch
    {
        public DateTime Time { get; private set; }
        public TimeSpan StopTime { get; private set; }


        public StopWatch()
        {
            
        }

        public void Start(DateTime dateTime)
        {
            Time = dateTime;
            Console.WriteLine("Started StopWatch at: " + Time);
        }


        public void Stop()
        {
            StopTime = DateTime.Now-Time;
            Console.WriteLine("Stoped watch at: " + DateTime.Now);
            Console.WriteLine("Time Elapsed: " + StopTime);

        }
    }
}
