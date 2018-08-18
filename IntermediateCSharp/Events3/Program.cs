using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events3
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneService phoneService = new PhoneService();
            RobotManager robotManager = new RobotManager();
            robotManager.RobotSleeped += phoneService.OnRobotSleeped;
            robotManager.Sleep();
        }
    }
}

