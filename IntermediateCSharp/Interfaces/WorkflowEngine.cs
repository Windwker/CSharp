using System.Collections.Generic;

namespace Interfaces
{
    public class WorkflowEngine
    {
        public void Run(List<IActivity> list)
        {
            foreach (var activity in list)
            {
                activity.Execute();
            }
        }
    }
}
