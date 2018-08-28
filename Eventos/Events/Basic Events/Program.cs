using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Events
{
    class Program
    {
        static void Main(string[] args)
        {

            Alarm alarm1 = new Alarm("1234 fake street");
            NotificationManager notificationManager = new NotificationManager();
            AlarmEngine alarmEngine = new AlarmEngine();
            alarmEngine.AlarmStarted += notificationManager.OnAlarmStarted;
            alarmEngine.StartAlarm(alarm1);
        }
    }

    public class NotificationManager
    {
        public void OnAlarmStarted(object src, AlarmEventArgs args)
        {
            System.Console.WriteLine("Message has been sent to "+args.Address);
        }
    }
}
