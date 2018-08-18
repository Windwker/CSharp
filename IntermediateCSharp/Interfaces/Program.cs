using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IActivity> activities = new List<IActivity>();
            IActivity Write = new WriteTestCases();
            IActivity Execute = new ExecuteTestCases();
            IActivity Report = new ReportBugs();
            activities.Add(Write);
            activities.Add(Execute);
            activities.Add(Report);
            WorkflowEngine engine = new WorkflowEngine();
            engine.Run(activities);
        }
    }
}
