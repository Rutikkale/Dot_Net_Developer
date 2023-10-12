using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nested_if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your email");
            string email = Console.ReadLine();


            if (email == "rutikkale17@gmail.com")
            {
                Console.WriteLine("Enter your password");
                string password = Console.ReadLine();
                if (password == "rutik123")
                {
                    Console.WriteLine("login sussesfull...");
                }
                else
                {
                    Console.WriteLine("Invalid password");
                }
            }
            else
            {
                Console.WriteLine("invalid email");
            }

            Console.ReadLine();
        }
    }
}
