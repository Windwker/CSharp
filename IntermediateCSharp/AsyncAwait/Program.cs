using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting program");
            var path = @"c:\Users\Javi\Test.txt";
           
            WriteAsync(path);
            Thread.Sleep(10000);
            Console.WriteLine("Finished");
            

        }

        static async Task WriteAsync(string path)
        {
            var webClient = new WebClient();

            List<string> listOfUrls = new List<string>();
            listOfUrls.Add("http://www.clarin.com");
            listOfUrls.Add("http://www.lavoz.com");
            listOfUrls.Add("http://www.infobae.com");
            listOfUrls.Add("http://www.lanacion.com");

            var streamWriter = new StreamWriter(path, true);
            foreach (var url in listOfUrls)
            {
                var html = await webClient.DownloadStringTaskAsync(url);
                await streamWriter.WriteAsync(html);

            }
            streamWriter.Dispose();

            Console.WriteLine("Finished downloading Data:");
            

       

           
        }
      
    }
}
