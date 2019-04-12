using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeDetails
{
    public class Manager : Employee
    {

        public Manager(string name, string street, string city, string state, string postalCode) :
              this(name, street, city, state, postalCode, 60000000)
        {

        }
        public Manager(string name, string street, string city, string state, string postalCode, double salary) : 
            base(name, street, city,state, postalCode, salary)
        {

        }
        public override string DoWork()
        {
            return "Manager does work too!";
        }   
        public override string DoWork(string workType)
        {
            return "supervising" + workType  ; 
        }
        public string GivePraise()
        {
            return "Manager giving praise";
        }
    }
}
