using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var_and_Dynamic_keyword
{
    internal class Program
    {
        // Example 1 of Var keyword

        //public static var show(var a, var b) // we can not used var in method or funtion 
        //{ 
        //    return a + b;
        //}

        // Example 2 of Dynamic Keyword

        public static void show(dynamic a)
        {
            Console.WriteLine(a);
        }

        //public static dynamic show(dynamic a)
        //{
        //    return a;
        //}



        static void Main(string[] args)
        {
            // Example 1 of var keyword

            // var a = "Rutik";
            //// a = 123;
            // Console.WriteLine(a.GetType());
            // Console.WriteLine(a.Length);
            // Console.WriteLine(a.ToUpper());
            // Console.ReadLine();

            // Example 2 of Dynamic Keyword

            //dynamic a;
            //a = "Rutik";
            //Console.WriteLine(a.GetType());
            //Console.WriteLine(a.Length);
            //Console.WriteLine(a.ToUpper());
            //Console.ReadLine();

            Program.show(1);
            Program.show("Rutik");
            Program.show(true);
            Program.show(false);
            Program.show(12.200);

            Console.ReadLine();
            


        }
    }
}
