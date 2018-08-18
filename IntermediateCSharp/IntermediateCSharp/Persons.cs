using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateCSharp
{
    public class Persons
    {
        private string _Name;
        private DateTime _birdthday;

        public void SetBirthdate(DateTime birthday)
        {
            _birdthday = birthday;
        }

        public DateTime GetBirthday()
        {
            return _birdthday;
        }
    }
}

