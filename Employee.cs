using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeDetails
{
    public class Employee
    {
        public string Name { get; set; } // Name property
        public AddressInfo Address { get; set; } // property from addressinfo class.
        public InsuranceInfo Insurance { get; set; } // property from Insurance Info class.
        public double Salary { get; set; }
        public Employee(string name, string street, string city, string state, string postalCode) :
            this(name, street, city, state, postalCode, 5000000)
        {
        }
        

       
        
        public Employee(string name, string street, string city, string state, string postalCode, double salary) // Constructor
        {
            Name = name;
            Salary = salary;
            Address = new AddressInfo()
            {

                Street = street,
                City = city,
                State = state,
                PostalCode = postalCode
            };
        }
        public virtual string DoWork() // Polymorphic method!
        {
            return "The employee is working ok!";
        }

        public virtual string DoWork(string workType) // Polymorphic method!
        {
            return "Doing" + workType;  
        }
        public override string ToString()
        {
            string retVal = Name + " " +
                Address.Street + " " +
                Address.City + " " +
                Address.State + " " +
                Address.PostalCode +
                "\tSalary: " + Salary + "\t"; 
            if (Insurance != null)
            {
                retVal += "" +
                    Insurance.PolicyName + " " +
                    Insurance.PolicyId;
            }
            return retVal;

        }

    }
}
