using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    class ComissionEmployee : Employee
    {
        //public int EmployeeID { get; set; }
        //public string Name { get; set; }
        //public string Department { get; set; }
        //public string Address { get; set; }

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

        //public void Print()
        //{
        //    Console.WriteLine("Employee ID: {0}\nName: {1}\nDepartment: {2}\nAdress:{3}\nTotal Sales: {4}\nComission: {5}\nEarnings:{6}\n", EmployeeID, Name, 
        //        Department, Address, TotalSales, ComRate, Earnings());
        //}

        public void Print()
        {
            base.Print();
            Console.WriteLine("Total Sales: {0:c2}\nComission: {1}\nEarnings:{2:c2}\n",
                 TotalSales, ComRate, Earnings());
        }
    }
}
