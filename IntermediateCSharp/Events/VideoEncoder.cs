using System;
using System.Threading;

namespace Events
{
    public class VideoEncoder
    {
        //1- Definir un delegado.
        //2- Definir un evento basado en el delegado
        //3- Levantar el evento.
        public delegate void VideoEncodedEventHandler(object source, EventArgs args);

        public event VideoEncodedEventHandler VideoEncoded;
        
        
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video");
            Thread.Sleep(4000);
            OnVideoEncoded();

        }

        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, EventArgs.Empty);
            }
        }
    }
}
