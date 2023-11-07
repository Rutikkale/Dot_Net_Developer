using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1) Example

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            // 2) Example

            Console.WriteLine("Enter your number");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <=10 ; i++) //conter variable 
            {
             Console.WriteLine(number + "X" + i + "=" + number*i);  // 2X1= 2

            }

            Console.WriteLine("for loop terminate...");
            Console.ReadLine();
        }
    }
}
