using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initialing_or_creating_array_with_user_input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example 1:
            //Console.WriteLine("How many number of atom you want to store in an array ?");
            //int num =int.Parse( Console.ReadLine());
            //int[] number = new int[num];

            //for (int i = 0; i < num; i++)
            //{
            //    Console.WriteLine("Enter Your Data:");
            //    int data = int.Parse( Console.ReadLine());
            //    number[i] = data;
            //}

            //Console.WriteLine("----------------------your Data-------------------------");
            //foreach(int item in number)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.ReadLine();




            //Example 2

            Console.WriteLine("How many number of atom you want store in an array ? ");
            int num = int.Parse(Console.ReadLine());
            string[] name = new string[num];

            for (int i = 0; i < num ; i++)

            {
                Console.WriteLine("Enter your Data" + (i+1));
                string data = Console.ReadLine();
                name[i] = data;
            }

            Console.WriteLine("----------------------Your Data-------------------------");
            foreach (string item in name) 
            {
            Console.WriteLine(item);
            }


            Console.ReadLine();

        }
    }
}
