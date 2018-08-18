using System;
namespace Events3
{
    public class RobotManager
    {

        public delegate void RobotSleepedEventHandler(object source, EventArgs args);
        public event RobotSleepedEventHandler RobotSleeped;
        Robot Robot = new Robot();
        


        public void Sleep()
        {
            System.Console.WriteLine("Robot is sleeping");
            OnRobotSleeped();
        }

        protected virtual void OnRobotSleeped()
        {
            if (RobotSleeped!=null)
            {
                RobotSleeped(this, EventArgs.Empty);
            }
        }
    }


}

