using System;
namespace Events3
{
    public class PhoneService
    {
        public void OnRobotSleeped(object source, EventArgs args)
        {
            Console.WriteLine("Phone Service");
        }
    }


}

