using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events4
{
    public class MailService
    {

        public EventHandler MailSent;

        public void OnPartyStarted(Object source, PersonEventArgs args)
        {
            Console.WriteLine(this + " notifying party started was sent" + args.Name);
            OnMailSent();
        }

        protected virtual void OnMailSent()
        {
            if (MailSent !=null)
            {
                MailSent(this, EventArgs.Empty);
            }
        }


    }

}
