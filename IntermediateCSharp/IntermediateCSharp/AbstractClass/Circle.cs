using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateCSharp.AbstractClass
{
    class Circle: Shape
    {
        public int Ratio { get; set; }
        public int Size { get; set; }

        public override void Draw()
        {
            Console.WriteLine("This is a Circle of ratio {0} and size {1}",Ratio,Size); 
        }
    }
}
