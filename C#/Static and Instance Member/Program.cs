using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_and_Instance_Member
{
    class student
    {
        // Instance variable
        public int rollno;
        public string FirstName;
        public string LastName;
        public int standard;


        // Static variable
        public static string school = "ABC School";
        public static int fees = 4000;

        // Instance method
        public void printFullName()
        {
        string fullName = this.FirstName + " " + this.LastName;
            Console.WriteLine("Your name is {0}",fullName);
        }

        // Static method

        public static int GetFees()
        {
            return fees;
        }

        public static int GetfeesAnnualIncrement()
        {
            return fees / 10;
        }

        public static int GetfeesAnnualIncrement(int fee)
        {
            return fee / 10;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student rutik = new student();
            rutik.rollno = 21;
            rutik.FirstName = "Rutik";
            rutik.LastName = "Kale";
            rutik.standard = 1;

            student arpit = new student();
            arpit.rollno = 22;
            arpit.FirstName = "Arpit";
            arpit.LastName = "Kale";
            arpit.standard = 2;


            Console.WriteLine(rutik.rollno);
            Console.WriteLine(rutik.FirstName);
            Console.WriteLine(rutik.LastName);
            Console.WriteLine(rutik.standard);
            rutik.printFullName();
            Console.WriteLine(student.school);
            Console.WriteLine(student.GetFees());
            Console.WriteLine(student.GetfeesAnnualIncrement());
            Console.WriteLine("--------------------------");

            Console.WriteLine(arpit.rollno);
            Console.WriteLine(arpit.FirstName);
            Console.WriteLine(arpit.LastName);
            Console.WriteLine(arpit.standard);
            arpit.printFullName();
            Console.WriteLine(student.school);
            Console.WriteLine(student.GetFees());
            
            Console.WriteLine(student.GetfeesAnnualIncrement(3000));
            Console.ReadLine();
        }
    }
}
