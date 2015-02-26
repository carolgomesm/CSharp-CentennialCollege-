using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    class HomeInsurance : Insurance
    {
        public double Area { get; set; }
        public string Type { get; set; }//for example Semis, Detached, Townhouse, etc.
        public int Year { get; set; }
        public double InsuranceAmt { get; set; }

        public HomeInsurance(int policyNumber, string name, string address, DateTime startDate, double area, string type, int year)
            : base(policyNumber, name, address, startDate)
        {
            this.Area = area;
            this.Type = type;
            this.Year = year;
        }

        public double  CalculateHomeInsurance()
        {
            int age = 2015 - Year;

            if (age >= 15)
                InsuranceAmt = 2500;
            else
                if (age >= 5 && age < 15)
                    InsuranceAmt = 1500;
                else
                    InsuranceAmt = 100;

            return InsuranceAmt;

        }

        public void Print()
        {
            base.Print();
            Console.WriteLine("Area: {0}\nType:{1}\nYear:{2}\nAnnual Home Insurance amount:{3:c2}", Area, Type, Year, InsuranceAmt);
        }

    }
}
