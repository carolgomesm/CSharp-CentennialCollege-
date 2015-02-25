using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    class EmployeeTest
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee( 3004,"Carolina", "Sales","Toronto");
            employee1.Print();


            ComissionEmployee employee2 = new ComissionEmployee(3004, "Carolina", "SETAS", "Toronto", 2000, 0.2);
            employee2.Print();

            Console.WriteLine("Earnings:" + employee2.Earnings());
            employee2.Print();
        }
    }
}
