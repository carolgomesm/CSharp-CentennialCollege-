using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    abstract class Insurance
    {
        private int policyNumber;
        private string customerName;
        private double monthlyAmount;

        public int PolicyNumber
        {
            get { return policyNumber; }
            set { policyNumber = value; }
        }
        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }
        public double MonthlyAmount
        {
            get { return monthlyAmount; }
            set { monthlyAmount = value; }
        }

        public abstract double CalcAnnualInsuranceAmount();

    }
}
