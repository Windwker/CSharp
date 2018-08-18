using System;
namespace Events5
{
    public class SmsService
    {
        public void OnAlarmRinging(object source, EventArgs args)
        {
            System.Console.WriteLine(this + "An SMS has been sent to the owner of the Alarm");
        }
    }
}
