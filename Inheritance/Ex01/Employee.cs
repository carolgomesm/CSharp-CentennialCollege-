using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    class Employee
    {
        //instance data members
        public int EmployeeID {get; set;}
        public string Name { get; set; }
        public string Department {get; set;}
        public string Address {get; set;}

        public Employee(int employeeID, string name, string department, string address)
        {
            this.EmployeeID = employeeID;
            this.Name = name;
            this.Department = department;
            this.Address = address;
        }

        public void Print()
        {
            Console.WriteLine("Employee ID: {0}\nName: {1}\nDepartment: {2}\nAdress:{3}", EmployeeID, Name, Department, Address);
        }
    }
}
