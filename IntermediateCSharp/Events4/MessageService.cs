using System;

namespace Events4
{
    public class MessageService
    {
        public void OnPartyStarted(Object source, PersonEventArgs args)
        {
            Console.WriteLine(this + " notifying party started was sent " + args.Name );
        }
    }

}
