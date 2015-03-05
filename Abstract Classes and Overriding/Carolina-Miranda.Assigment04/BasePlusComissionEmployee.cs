using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carolina_Miranda.Assigment04
{
    class BasePlusComissionEmployee : ComissionEmployee
    {
        private double baseSalary;

        public double BaseSalary
        {
            get { return baseSalary; }
            set { baseSalary = value; }
        }

        public BasePlusComissionEmployee(string firstName, string lastName, int sin, double grossSales, double comissionRate, double baseSalary)
            : base(firstName, lastName, sin, grossSales, comissionRate)
        {
            this.BaseSalary = baseSalary;
        }

        public override double Earnings()
        {
            base.Earnings();
            double income = baseSalary + (GrossSales * ComissionRate);
            return income;
        }

        public override void ToString()
        {
            base.ToString();
            Console.WriteLine("Total Earnings with Salary: {0:c2}\n", Earnings());
        }

    }
}
