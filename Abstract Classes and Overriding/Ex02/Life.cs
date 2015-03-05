using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    class Life : Insurance
    {
        public int YearOfBirth { get; set; }
        
        public override double CalcAnnualInsuranceAmount()
        {
            int age = 2015 - YearOfBirth;
            if (age < 25)
                MonthlyAmount = 75.00;
            else
                if (age >= 25 && age < 40)
                    MonthlyAmount = 100.00;
                else
                    if (age > 40)
                        MonthlyAmount = 125.00;

            return MonthlyAmount * 12;
        }
    }
}
