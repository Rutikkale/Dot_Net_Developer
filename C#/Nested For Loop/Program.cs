using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_For_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Hello");
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine("Hey");
                }
            }
            Console.WriteLine("Loop Terminates...");
            Console.ReadLine();
        }
    }
}
