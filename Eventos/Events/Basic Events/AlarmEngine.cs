using System;

namespace Basic_Events
{
    public class AlarmEngine
    {
        public EventHandler<AlarmEventArgs> AlarmStarted;


        public void StartAlarm(Alarm alarm)
        {
            Console.WriteLine(alarm.Address + " will sound .");
            OnAlarmStarted(alarm);
        }
        

        protected virtual void OnAlarmStarted(Alarm alarm)
        {
            AlarmEventArgs alarmEventArgs = new AlarmEventArgs();
            if (AlarmStarted != null)
            {
                alarmEventArgs.Address = alarm.Address;
                AlarmStarted(this, alarmEventArgs);
            }
        }

    }
}
