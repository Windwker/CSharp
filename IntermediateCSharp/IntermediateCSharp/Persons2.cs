using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateCSharp
{
    public class Persons2
    {
        public Persons2(DateTime time)
        {
            BirthDate = time;
        }
        public DateTime BirthDate { get; private set; } // Auto implemented property
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - BirthDate;
                var years = timeSpan.Days / 365;
                return years;
            }
            
          
        }

    }
}

