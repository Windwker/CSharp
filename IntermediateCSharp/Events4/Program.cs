using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events4
{
    class Program
    {
        static void Main(string[] args)
        {
            PartyEvent partyEvent = new PartyEvent(); //publisher
            MailService mailService = new MailService(); //suscriber
            MessageService messageService = new MessageService(); // suscriber
            Person person = new Person("Juan");
            partyEvent.PartyStarted += mailService.OnPartyStarted ;
            partyEvent.PartyStarted += messageService.OnPartyStarted;
            mailService.MailSent += person.OnMailSent;
            
            partyEvent.StartParty(person);
        }
    }



}
