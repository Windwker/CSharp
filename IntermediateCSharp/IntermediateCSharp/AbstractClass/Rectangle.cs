using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateCSharp.AbstractClass
{
    class Rectangle: Shape
    {
        public string Type { get; private set; }
        public string Name { get; private set; }
        public Rectangle(string type, string name)
        {
            Type = type;
            Name = name;
        }

        public override void Draw()
        {
            Console.WriteLine("This is a Rectangle type {0} with name {1}",Type,Name);
        }
    }
}
