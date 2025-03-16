using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{

    public class Employee

    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Salary { get; set; }
        public int Age { get; set; }

        public Employee(int id, string name, string salary, int age)
        {
            Id = id;
            Name = name;
            Salary = salary;
            Age = age;
        }

        public Employee()
        {
        }

        public void PrintEmployee()
        {
            Console.WriteLine("Method created to print Employee Details :");
        }

        public void PrintEmployee(string name, int age)
        {
            Console.WriteLine("Method created to print Employee Details :");
        }


    }

    
}
