using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    class SalaryAndComissionEmployee : Employee
    {
        public double Salary { get; set; }

        public SalaryAndComissionEmployee(int employeeID, string name, string department, string address, double salary)
            : base(employeeID, name, department, address)
        {
            this.Salary = salary;
        }
    }
}
