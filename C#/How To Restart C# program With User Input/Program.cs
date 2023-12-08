using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace How_To_Restart_CSharp_program_With_User_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Example 1:

            //string confirm;
            //do
            //{

            //    Console.WriteLine("Enter your frist No:");
            //    int num1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter your Second No:");
            //    int num2 = int.Parse(Console.ReadLine());
            //    int add = num1 + num2;
            //    Console.WriteLine("Result:" + add);
            //    Console.WriteLine("Do you want to repeat your program? Yes/No");
            //    confirm = Console.ReadLine().ToLower();

            //}
            //while (confirm =="yes");

            //Console.WriteLine("Out of the loop");
            //Console.ReadLine();

            //Example 2

            while (true)
            {
                Console.WriteLine("Enter your frist No:");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your Second No:");
                int num2 = int.Parse(Console.ReadLine());
                int add = num1 + num2;
                Console.WriteLine("Result:" + add);
                Console.WriteLine("Do you want to repeat your program? Yes/No");
                string confirm = Console.ReadLine().ToLower();

                if (confirm == "yes")
                {
                    continue;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("out of the loop");
            Console.ReadLine();




        }
    }
}
