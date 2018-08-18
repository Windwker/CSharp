using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events10
{
    public class NotificationManager
    {
     public void OnClassStarted(object source, SchoolEventArgs args)
        {
            Console.WriteLine("Classes started in: " + args.Name);
        }


        public void OnStudentAdded(object source, PersonEventArgs args)
        {
            Console.WriteLine("A new student was added: " + args.Name);
        }
    }
}
