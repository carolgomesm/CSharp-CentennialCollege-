using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class BankAccount
    {
        public int AccountID { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }

        public BankAccount(int accountID, string name, double balance)
        {
            this.AccountID = accountID;
            this.Name = name;
            this.Balance = balance;
        }//end of constructor

        public void Print()
        {
            Console.WriteLine("Account ID:{0}\nName: {1}\nBalance: {2:c2}", AccountID, Name, Balance);
        }
    }
}
