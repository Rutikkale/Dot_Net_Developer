using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Employees
    {
        // Default Constructor
        //public Program()
        //{
        //    // Default constructor
        //    Console.WriteLine("constructor Invokes");
        //}

        // Parameterized Constructor

        int EmpId;
        string EmpName;
        int EmpAge;

        public Employees(int EmpId, string EmpName, int EmpAge)
        {
            this.EmpId = EmpId;
            this.EmpName = EmpName;
            this.EmpAge = EmpAge;
        }

        public int getEmpId()
        {
            return this.EmpId;

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
            // Default constructor 
            // Program p = new Program();
            //Console.ReadLine();

            // Parameterized constructor

            Employees Rutik = new Employees(48,"Rutik kale",23);
            Employees Arpit = new Employees(40, "Arpit kale", 18);

            Console.WriteLine("Employees id is:{0}",Rutik.getEmpId());
            Console.WriteLine("Employees id is:{0}", Rutik.getEmpName());
            Console.WriteLine("Employees id is:{0}", Rutik.getEmpAge());

            Console.WriteLine("--------------------------------------");
          
            Console.WriteLine("Employees id is:{0}", Arpit.getEmpId());
            Console.WriteLine("Employees id is:{0}", Arpit.getEmpName());
            Console.WriteLine("Employees id is:{0}", Arpit.getEmpAge());
            Console.ReadLine();
        }
    }
}
