using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class CheckingAccount : BankAccount
    {
        private double transactionFee;

        //propertie
        public  double TransactionFee
        {
            get { return transactionFee; }
            set { transactionFee = value; }
        }

        //constructor
         public CheckingAccount(int accountID, string name, double balance, double transactionFee) 
             : base (accountID, name, balance)
        {
            this.TransactionFee = transactionFee;

        }//end of constructor


         public double Withdraw(double amt)
         {
            Balance = Balance  - amt - (amt * transactionFee);
            return Balance;
         }

         public void Print()
         {
             base.Print();
                 Console.WriteLine("Transaction Fee: {0}%", TransactionFee);
         }
    }
}
