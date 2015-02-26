using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class SavingAccount : BankAccount
    {
        public double RateInterest { get; set; }

        public SavingAccount(int accountID, string name, double balance, double rateInterest)
            : base (accountID, name, balance)
        {
            this.RateInterest = rateInterest;
        }

        public double CalculateInterest()
        {
            return Balance * RateInterest;
        }

        public void Print()
        {
            base.Print();
            Console.WriteLine("Interest:{0:c2}\n", CalculateInterest());
        }
    }
}
