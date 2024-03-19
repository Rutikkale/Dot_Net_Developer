using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{

    class VisitingEmployees: Employees // Child class or Derived class of Employees
    {
        int VisitingSalary;
        int VisitingHours;
    }
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
            VisitingEmployees Rutik = new VisitingEmployees();
            Rutik.EmpId = 111;

            PermanentEmployees Arpit = new PermanentEmployees();
            Arpit.EmpId = 222;
            Arpit.show();

            Console.WriteLine(Rutik.EmpId);
            Console.WriteLine(Arpit.EmpId);

            Console.ReadLine();  
        }
    }
}
