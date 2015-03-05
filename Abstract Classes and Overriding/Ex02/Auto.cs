using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    class Auto : Insurance 
    {
        public int VinNumber { get; set; }
        public string Make {get; set;}
        public int Year { get; set; }

        public override double CalcAnnualInsuranceAmount()
        {
            int age = 2015 - Year;
            if (age < 3)
                MonthlyAmount = 200.00;
            else
                if (age >= 3 && age < 8)
                    MonthlyAmount = 150.00;
                else
                    if (age > 8)
                        MonthlyAmount = 100.00;

            return MonthlyAmount * 12;
        }
    }
}
