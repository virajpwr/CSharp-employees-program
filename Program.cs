using System;
using System.Threading;
using System.Data;
using System.Collections.Generic;

namespace EmployeeDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Joe= new Employee("Joe", "Glas 100 street", "Macc","Cheshire", "SK10 1AN");
            Console.WriteLine(Joe.ToString());
            Joe.Insurance = new InsuranceInfo() { PolicyName = "Motor", PolicyId = "419538" };
            Console.WriteLine(Joe.ToString());
            Manager viraj = new Manager("Viraj", "yop 120 street", "Macc", "Cheshire", "SK45 3KL",50000000);

            Console.WriteLine(viraj);
            Console.WriteLine(Joe.DoWork());
            Console.WriteLine(viraj.DoWork("Programming"));

            Employee Dave =  new Manager("Dave", "Gl a s 100 street", "Macc", "Cheshire", "SK10 1AN");
            Console.WriteLine("Derived class" + Dave.DoWork()); // Override in derived class..

            Console.WriteLine("====================================================================");

            List<Employee> employees = new List<Employee>();
            employees.Add(Joe);
            employees.Add(Dave);
            employees.Add(viraj);

            foreach(Employee emp in employees)
            {
                Console.WriteLine(emp.DoWork());
            }

        }
    }
}
