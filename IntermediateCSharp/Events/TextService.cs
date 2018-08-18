using System;

namespace Events

{
    public class TextService
    {
        public void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("Sending an SMS");
        }
    }
}
