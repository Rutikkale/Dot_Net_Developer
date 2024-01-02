using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_Type_Reference_Type
{
  // struct -- Value type -- stack memory

  /*  struct Employee
    {
        public int Salary;
        public int Age;
    }
  */

    // Class -- Reference Type -- Heap memory

    class Employee
    {
        public int salary;
        public int Age;

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // struct example 1

           /* Employee e = new Employee();
            e.Salary = 5000;
            e.Age = 23;

            Employee e1 = e;
            Employee e2 = e;
            e.Age = 25;

            Console.WriteLine(e.Age);
            Console.WriteLine(e1.Age);
            Console.WriteLine(e2.Age);
            Console.ReadLine();
           */

            // Class Example 2
            Employee e = new Employee();
            e.salary = 5000;
            e.Age = 23;

            Employee e1 = e;
            Employee e2 = e;

            e.Age = 25;
            Console.WriteLine(e.Age);
            Console.WriteLine(e1.Age);
            Console.WriteLine(e2.Age);
            Console.ReadLine();
        }
    }
}
