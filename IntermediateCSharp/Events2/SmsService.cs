
using System;

namespace Events2
{
    public class SmsService
    {
        public void OnAnimalHairDressed(object source, EventArgs args)
        {
            Console.WriteLine("Sending SMS Messaje");

        }
    }
}
