using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Constructor
{
    class person
    {
        public static string PersonName;
        public static int PersonAge;

        static person()
        {
         PersonName = "Rutik";
         PersonAge = 23;
         Console.WriteLine("Static Constructor Invoked !!");
        }

        public person()
        {
            Console.WriteLine("Default Constructor Invoked !!");

        }

        public static void getPersonDetails()
        {
            Console.WriteLine("Person Name is:{0}",PersonName);
            Console.WriteLine("Person Age is:{0}",PersonAge);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
          person rutik = new person();
          person arpit = new person();

         // person.getPersonDetails();
            Console.ReadLine();
        }
    }
}
