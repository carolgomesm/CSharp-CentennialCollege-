using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class BankAccountTest
    {
        static void Main(string[] args)
        {
            BankAccount client = new BankAccount(12345, "Carlos", 2000);
            client.Print();
            Console.WriteLine();

            SavingAccount client2 = new SavingAccount(3456, "Vanilda", 3000, 0.2);
            client2.CalculateInterest();
            client2.Print();

        }
    }
}
