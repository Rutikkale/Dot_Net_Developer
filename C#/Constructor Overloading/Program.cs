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
            Console.WriteLine("This is a Frist Constructor");
        }

        public Program(int a , int b)
        {
            Console.WriteLine("This is a Second Constructor :{0}",a + b);
        }

        public Program(int a, int b, int c)
        {
            Console.WriteLine("This is a Third Constructor :{0}", a + b + c);
        }

        public Program(string a, string b, string c)
        {
            Console.WriteLine("This is a Fourth Constructor :{0}", a + b + c);
        }
        static void Main(string[] args)
        {
            Program p = new Program(10,20);
            Program p1 = new Program(10, 20 ,50);
            Program p2 = new Program("A","B","C");

            Console.ReadLine();

        }
    }
}
