using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Employees
    {
        int EmpID;
        string EmpName;
        int EmpAge;

        public Employees(int EmpID, string EmpName,int EmpAge)
        {
            this.EmpID = EmpID;
            this.EmpName = EmpName;
            this.EmpAge = EmpAge;
        }

       public int getEmpID()
        {
           return this.EmpID;
        }

        public string getEmpName()
        {
            return this.EmpName;

        }
        public int getEmpAge()
        {
            return this.EmpAge;
        }

      
        
        static void Main(string[] args)
        {
            Employees Rutik = new Employees(1,"Rutik Kale",22);
            Employees Arpit = new Employees(2, "Arpit Kale",18);

            Console.WriteLine("Employees ID is :{0}",Rutik.getEmpID());
            Console.WriteLine("Employees Name is :{0} ", Rutik.getEmpName());
            Console.WriteLine("Employees Age is : {0}", Rutik.getEmpAge());
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Employees ID is :{0}", Arpit.getEmpID());
            Console.WriteLine("Employees Name is :{0} ", Arpit.getEmpName());
            Console.WriteLine("Employees Age is : {0}", Arpit.getEmpAge());

            Console.ReadLine();
            
        }
    }
}
