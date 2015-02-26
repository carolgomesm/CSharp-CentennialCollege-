using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    class Insurance
    {
        public int PolicyNumber { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        private DateTime StartDate { get; set; }

        public Insurance(int policyNumber, string name, string address, DateTime startDate)
        {
            this.PolicyNumber = policyNumber;
            this.Name = name;
            this.Address = address;
            this.StartDate = startDate;
        }

        public void Print()
        {
            Console.WriteLine("\nPolicy Number:{0}\nName:{1}\nAddress:{2}\nStart Date:{3:yyyy/MM/dd}", PolicyNumber, Name, Address, StartDate);
        }
    }
}
