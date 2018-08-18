using System;

namespace Events4
{
    public class PartyEvent
    {
        //public delegate void PartyStartedEventHandler(object source, PersonEventArgs args);
        //Func<object source, EventArgs args>
        public EventHandler<PersonEventArgs> PartyStarted;
       // public event PartyStartedEventHandler PartyStarted;
        
        public void StartParty(Person person)
        {

            System.Console.WriteLine("Party has started");
            OnPartyStarted(person);
        }

        protected virtual void OnPartyStarted(Person person)
        {
            if (PartyStarted != null)
            {
                PersonEventArgs personEventArgs = new PersonEventArgs();
                personEventArgs.Name = person.Name;
                PartyStarted(this, personEventArgs);

            }
        }
    }



}
