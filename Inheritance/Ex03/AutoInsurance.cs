using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    class AutoInsurance : Insurance
    {
        private int vinNumber;
        private string make;
        private int year;
        private int insuranceAmt;

        public int VinNumber 
        { 
            get 
            { return vinNumber; }
            set
            { vinNumber = value; }
        
        }
        public string Make
        { 
            get 
            { return make; }
            set
            { make = value; }
        }
        public int Year 
        { 
            get
            { return year; }
            set
            { year = value; }
        }
        public int InsuranceAmt
        {
            get
            { return insuranceAmt;}
            set
            { insuranceAmt = value;}
        }

        public AutoInsurance(int policyNumber, string name, string address, DateTime startDate, int vinNumber, string make, int year)
            : base (policyNumber, name, address, startDate)
        {
            this.VinNumber = vinNumber ;
            this.Make = make;
            this.Year = year;
        }

        public int CalculateInsurance()
        {
            int age = 2015 - Year;

            if (age >= 15)
                InsuranceAmt = 1500;
            else
                if (age >= 5 && age < 15)
                    InsuranceAmt = 1000;
                else
                    InsuranceAmt = 500;

            return InsuranceAmt;

        }

        public void Print()
        {
            base.Print();
            Console.WriteLine("Vin Number: {0}\nMake:{1}\nYear:{2}\nAnnual Auto Insurance amount:{3:c2}", VinNumber, Make, Year, InsuranceAmt);
        }
    }
    }

