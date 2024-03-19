using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Inheritance
{
    class PermanentEmployees : Employees // Child class or Derived class of Employees
    {
        int PermanentSalary;
        int PermanentHours;
    }
    class Employees // Base Class or Parents class
    {
        public int EmpId;
        public string EmpName;
        public int EmpAge;
        public int EmpContactNo;

        public void show()
        {
            Console.WriteLine("This is a method of base class !!");
        }
    }

        internal class Program
    {
        static void Main(string[] args)
        {
           PermanentEmployees Rutik = new PermanentEmployees();
            Rutik.EmpAge = 23;
            Rutik.show();
            Console.WriteLine( Rutik.EmpAge);
            Console.ReadLine();
        }
    }
}
