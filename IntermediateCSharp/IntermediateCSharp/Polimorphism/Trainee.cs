﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateCSharp.Polimorphism
{
    class Trainee : Employee
    {
        public override void calculateSalary()
        {
            Console.WriteLine("This is the salary of the trainee");
        }
    }
}
