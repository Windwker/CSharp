using System;

namespace Events5
{
    public class AlarmEngine
    {


        public delegate void AlarmActivatedEventHandler(object source, EventArgs args);
        public event AlarmActivatedEventHandler AlarmActivated;
        public delegate void AlarmDisabledEventHandler(object source, EventArgs args);
        public event AlarmDisabledEventHandler AlarmDisabled;
        public delegate void AlarmRingingEventHandler(object source, EventArgs args);
        public event AlarmRingingEventHandler AlarmRinging;

        public void ActivateAlarm(Alarm alarm)

        {
            Console.WriteLine("Alarm has been activated");
            OnAlarmActivated();
        }

        public void DisableAlarm(Alarm alarm)
        {
            Console.WriteLine("Alarm has been disabled");
            OnAlarmDisabled();
        }

        public void Ring(Alarm alarm)
        {
            Console.WriteLine("Alarm is Ringing");
            OnAlarmRinging();
        }
        

        protected virtual void OnAlarmActivated()
        {
            if(AlarmActivated != null)
            {
                AlarmActivated(this, EventArgs.Empty);
            }
        }

        protected virtual void OnAlarmDisabled()
        {
            if(AlarmDisabled != null)
            {
                AlarmDisabled(this, EventArgs.Empty);
            }
        }

        protected virtual void OnAlarmRinging()
        {
            if (AlarmRinging!= null)
            {
                AlarmRinging(this, EventArgs.Empty);
            }
        }

    }
}
