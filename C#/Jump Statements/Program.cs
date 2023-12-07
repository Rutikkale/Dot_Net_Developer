using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jump_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Break statement:

            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 5)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Loop terminates...");
            //Console.ReadLine();


            //Continue statement:

            // Example 1:

            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 5)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("loop terminates...!");
            //Console.ReadLine();

            // Example 2:
            // odd number

            //for (int i = 0; i < 10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("loop terminates...!");
            //Console.ReadLine();



            // Example 3:
            //even number

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 1)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("loop terminates...!");
            Console.ReadLine();




            // Goto statement:

            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 5)
            //    {
            //        goto Stop;
            //    }
            //    Console.WriteLine(i);

            //}
            //Console.WriteLine("Loop terminates...!");
            //Stop:
            //Console.WriteLine("Program Exits...");
            //Console.ReadLine();




        }
    }
}
