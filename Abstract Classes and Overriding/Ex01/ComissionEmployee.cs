using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carolina_Miranda.Assigment04
{
    class ComissionEmployee
    {
        string firstName;
        string lastName;
        int sin;
        double grossSales;
        double comissionRate;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName  = value; }
        }
        public int Sin
        {
            get { return sin; }
            set { sin = value; }
        }
        public double GrossSales
        {
            get { return grossSales; }
            set { grossSales = value; }
        }
        public double ComissionRate
        {
            get { return comissionRate; }
            set { comissionRate = value; }
        }

        public ComissionEmployee(string firstName, string lastName, int sin, double grossSales, double comissionRate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Sin = sin;
            this.GrossSales = grossSales;
            this.ComissionRate = comissionRate;
        }

        public virtual void ToString()
        {
            Console.WriteLine("\nFirst Name:{0}\nLast Name:{1}\nSIN:{2}\nGross Sales:{3:c2}\nComission Rate:{4}", FirstName, LastName,Sin,GrossSales,ComissionRate);
        }

        public virtual double Earnings()
        {
            return GrossSales * comissionRate;
        }
    }
}
