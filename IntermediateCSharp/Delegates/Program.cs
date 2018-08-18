using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {

            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            
           PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            processor.Process("Image.jpg",filterHandler);
        }
    }
}
