using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestString
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFile = "aseewewd.xaml";
            string searchString = ".xaml";
            int startIndex = inputFile.IndexOf(searchString);
            string outputFile = inputFile.Substring(0, startIndex);
            outputFile += ".png";
            Console.WriteLine(outputFile);

            
            
        }
    }
}
