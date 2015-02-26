using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    class ComissionEmployee : Employee
    {
        public double TotalSales { get; set; }
        public double ComRate { get; set; }

        public ComissionEmployee(int employeeID, string name, string department, string address, double totalSales, double comRate): 
            base (employeeID, name, department, address)
        {
            this.TotalSales = totalSales;
            this.ComRate = comRate;
        }

        public double Earnings()
            {
                return TotalSales * ComRate;
            }

        public void Print()
        {
            base.Print();
            Console.WriteLine("Total Sales: {0:c2}\nComission: {1}\nEarnings:{2:c2}\n",
                 TotalSales, ComRate, Earnings());
        }
    }
}
