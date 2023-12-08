using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Overloading
{
    internal class Program
    {
        public Program()
        {
            Console.WriteLine("this is the first constructor");
        } 
        
        public Program(int a, int b)
        {
            Console.WriteLine("this is the second constructor: {0}",a+b);
        }

        public Program(int a, int b,int c)
        {
            Console.WriteLine("this is the third constructor: {0}", a + b + c);
        }

        public Program(String a, String b, String c)
        {
            Console.WriteLine("this is the third constructor: {0}", a + b + c);
        }
        static void Main(string[] args)
        {
            // Constructor Overloading

            Program p1 = new Program(20,10);
            Program p2 = new Program(20, 10,10);
            Program P3 = new Program("Rutik"," Kisanrao ","Kale");

            Console.ReadLine();
        }
    }
}
