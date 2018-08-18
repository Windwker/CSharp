using System;

namespace Events2
{
    public class MailService
    {
        public void OnAnimalHairDressed(object source, EventArgs args)
        {
            Console.WriteLine("Mail service enabled, sending mail to.");
        }
    }
}
