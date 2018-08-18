using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events5
{
    class Program
    {
        static void Main(string[] args)
        {
            Alarm alarm = new Alarm();
            AlarmEngine engine = new AlarmEngine();
            SmsService service = new SmsService();
            engine.ActivateAlarm(alarm);
            engine.AlarmRinging += service.OnAlarmRinging;
            engine.Ring(alarm);
            engine.DisableAlarm(alarm);
            throw new System.Exception("Exception");
        }
    }
}
