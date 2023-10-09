using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_construct_IF_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Example 1

            //int x = 10;

            //if (x>20)
            //{
            //    Console.WriteLine("the x is greater");

            //}
            //else
            //{
            //    Console.WriteLine(" the x is lesser");
            //}

            //Console.ReadLine();


            //Example 2

            Console.WriteLine("Enter username");
            string username = Console.ReadLine();
            Console.WriteLine("Enter password");
            string password = Console.ReadLine();

            if (username == "rutik" && password == "rutik123")
            {
                Console.WriteLine("login sucessful");
            }
            else
            {
                Console.WriteLine("incorret username or password");
            }
            Console.ReadLine();

        }
    }
}
