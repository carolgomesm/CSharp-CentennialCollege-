using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carolina_Miranda_LabAssigment5
{
    class SalesPersonTest
    {
        static void Main(string[] args)
        {
            RealStateSalesPerson person = new RealStateSalesPerson("Carlos", "Ferreira", 0.1);
            Console.WriteLine(person.FullName());
            person.MakeSale(4000);
            person.SalesSpeech();
            person.MakeSale(2000);
            person.SalesSpeech();

            GirlScout girl = new GirlScout("Vanilda", "Ferreira", 5);
            Console.WriteLine(girl.FullName());
            girl.MakeSale(10);
            girl.SalesSpeech();
            girl.MakeSale(5);
            girl.SalesSpeech();


        }
    }
}
