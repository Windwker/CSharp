using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video();
            video.Title = "Title1";
            var MailService = new MailService();
            var videoEncoder = new VideoEncoder();
            videoEncoder.VideoEncoded += MailService.OnVideoEncoded;
            videoEncoder.Encode(video);
        }
    }
}
