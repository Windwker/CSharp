using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateCSharp.Polimorphism
{
    class SalaryCalculator: Employee
    {
        public void CalculateSalary(List<Employee> employees)
        {

            foreach (var employee  in employees)
            {
                employee.calculateSalary();
            }
        }
    }
}
