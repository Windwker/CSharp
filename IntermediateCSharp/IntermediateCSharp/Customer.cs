using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateCSharp
{
    public class Customer
    {
        public int Id;
        public String Name;
       readonly public List<Order> Orders = new List<Order>();


        public Customer(int Id)
        {
            this.Id = Id;
        }

        public Customer(int Id, String Name)
            :this(Id)
        {
            this.Name = Name;

        }

        public void Promote()
        {
                  

    }
}
}
