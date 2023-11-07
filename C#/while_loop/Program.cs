using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number");
            int number = int.Parse(Console.ReadLine());

            int i = 1;

            while (i <= 10)
            {
                Console.WriteLine(number + "X" + i + "=" + number*i);
                i++;
            }
            Console.WriteLine("while loop terminated...");
            Console.ReadLine();
        }
    }
}
