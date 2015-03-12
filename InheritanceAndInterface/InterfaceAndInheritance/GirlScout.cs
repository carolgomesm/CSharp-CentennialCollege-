using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carolina_Miranda_LabAssigment5
{
    class GirlScout : SalesPerson
    {
        protected int boxSold;

        public int BoxSold
        {
            get
            {
                return boxSold;
            }
            set
            {
                boxSold = 0;
                boxSold = value;
            }
        }

         public GirlScout (string firstName, string lastName,int boxSold) : base (firstName, lastName)
        {
            this.BoxSold = boxSold;
        }

     
        public override double MakeSale(int newBoxSold)
        {
            BoxSold = BoxSold + newBoxSold;
            return BoxSold;
        }
        
        public override void SalesSpeech()
        {
            Console.WriteLine(" Hi {0} {1}, you sold {2} boxes of cookies", FirstName, LastName, BoxSold);
        }

        public override string FullName()
        {
            return FirstName + " " + LastName;
        }

    }
}
