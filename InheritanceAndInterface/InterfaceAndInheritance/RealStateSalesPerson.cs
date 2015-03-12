using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carolina_Miranda_LabAssigment5
{
    class RealStateSalesPerson : SalesPerson
    {
        protected int totalValueSold;
        protected double comission;
        private double comissionRate;

        public int TotalValueSold
        {
            get
            {
                return totalValueSold;
            }

            set
            {
                totalValueSold = 0;
                totalValueSold = value;
            }
        }
        public double Comission
        {
            get
            { 
                return comission;
            }
            set
            {
                comission = 0;
                comission = value;
            }
        }
        public double ComissionRate
        {
            get
            {
                return comissionRate;
            }
            set
            {
                comissionRate = value;
            }
        }

        public RealStateSalesPerson(string firstName, string lastName, double comissionRate) : base (firstName, lastName)
        {
            this.ComissionRate = comissionRate;
        }

        public override void SalesSpeech()
        {
            Console.WriteLine("Hi {0} {1}, you sold a total of {2}. Your Comission is {3}", FirstName, LastName, TotalValueSold, Comission);
        }

        public override double MakeSale (int houseValue)
        {
            Comission = TotalValueSold * ComissionRate;
            TotalValueSold = TotalValueSold + houseValue;
            return Comission;
        }

        public override string FullName()
        {
            return FirstName + " " + LastName;
        }

    }
}
