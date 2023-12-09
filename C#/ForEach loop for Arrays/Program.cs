using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEach_loop_for_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example 1 for loop and foreach loop for arrays

            //int[] numbers = new int[4];

            //numbers[0] = 10;
            //numbers[1] = 20;
            //numbers[2] = 30;
            //numbers[3] = 40;

            ////for (int i = 0; i < numbers.Length ; i++)
            ////{
            ////    Console.WriteLine(numbers[i]);
            ////}


            //foreach (int no in numbers)
            //{
            //    Console.WriteLine(no);
            //}
            //Console.ReadLine();

            // Example 2 

            string[] name = new string[4];
            name[0] = "Rutik";
            name[1] = "Arpit";
            name[2] = "Harshal";
            name[3] = "Akshay";

            foreach (string iteam in name)
            {
                Console.WriteLine(iteam);
            }

            Console.ReadLine();
                
        }
    }
}
