using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carolina_Miranda_LabAssigment5
{
    abstract class SalesPerson : ISallable
    {
        protected string FirstName { get; set; }
        protected string LastName { get; set; }

        public SalesPerson(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public abstract string FullName();
        public abstract double MakeSale(int x);
        public abstract void SalesSpeech();

    }
}
