using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carolina_Miranda.Assigment04
{
    class ComissionEmployeesTest
    {
        static void Main(string[] args)
        {
            ComissionEmployee employee = new ComissionEmployee("Carolina", "Miranda", 909876730, 10000, 0.1);
            employee.ToString();

            BasePlusComissionEmployee employee1 = new BasePlusComissionEmployee("Carlos", "Ferreira", 209093010, 20000, 0.05, 2500);
            employee1.Earnings();
            employee1.ToString();


        }
    }
}
