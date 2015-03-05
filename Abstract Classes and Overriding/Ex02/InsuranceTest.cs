using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    class InsuranceTest
    {
        static void Main(string[] args)
        {
            Life customer1 = new Life();
            Console.WriteLine("*-------- Life Insurance-------*");
            Console.Write("Please, enter your full name: ");
            customer1.CustomerName = Console.ReadLine();

            Console.Write("Enter your Policy Number: ");
            customer1.PolicyNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your Year of Birth: ");
            customer1.YearOfBirth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nHi {0}!\nYour Policy number is {1}\nYour year of birth is {2}\nYour Annual Insurance amount is {3:c2}",
               customer1.CustomerName, customer1.PolicyNumber, customer1.YearOfBirth, customer1.CalcAnnualInsuranceAmount());

            Auto customer2 = new Auto();
            Console.WriteLine("\n");
            Console.WriteLine("*-------- Auto Insurance-------*");
            Console.Write("\nPlease, enter your full name: ");
            customer2.CustomerName = Console.ReadLine();
            Console.Write("Enter your Policy Number: ");
            customer2.PolicyNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your VIN Number: ");
            customer2.VinNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the make of the car: ");
            customer2.Make = Console.ReadLine();
            Console.Write("Enter your Car's Year: ");
            customer2.Year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nHi {0}!\nYour Policy number is {1}\nYour car VIN Number is {2}\nYour Car make is {3}\nThe year of fabrication is {4}.\nYour Annual Insurance amount is {5:c2}",
               customer2.CustomerName, customer2.PolicyNumber, customer2.VinNumber, customer2.Make, customer2.Year, customer2.CalcAnnualInsuranceAmount());

        }
    }
}
