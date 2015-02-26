using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    class InsuranceTest
    {
        static void Main(string[] args)
        {
            Insurance client = new Insurance(3450, "Bob", "Mississauga", new DateTime (2015, 2, 26));
            client.Print();

            AutoInsurance client2 = new AutoInsurance(3450, "Bob", "Mississauga", new DateTime(2015, 2, 26), 39091284, "Honda", 2005);
            client2.CalculateInsurance();
            client2.Print();

            HomeInsurance client3 = new HomeInsurance(30099, "Marley", "Sao Paulo", new DateTime(2015, 2, 20), 1000, "Condo", 2009);
            client3.CalculateHomeInsurance();
            client3.Print();
        }
    }
}
