using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ternary_or_conditional_operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1)Example

            //int a = 10;
            //string b = (a > 20) ? "A is greater" : "A is lesser";
            //Console.WriteLine(b);
            //Console.ReadLine();

            //o/p: A is lesser

            //int a = 50;
            //String b = (a > 20) ? "A is greater" : "A is lesser";
            //Console.WriteLine(b);
            //Console.ReadLine();

            //o/p: A is greater



            // 2)Example

            int a = int.Parse(Console.ReadLine());
            string b = (a >= 18) ? "You are eligible for vote" : "You are not eligible for vote";
            Console.WriteLine(b);
            Console.ReadLine();

            //o/p: 20
            //     You are eligible for vote



        }
    }
}
