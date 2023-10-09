using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_construct_If_else_If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Percentage");
            int Percentage = int.Parse(Console.ReadLine());

            if(Percentage >= 80) 
            {
                Console.WriteLine("Grade: A-1");
            }
            else if (Percentage >=70)
            {
                Console.WriteLine("Grade: A");
            }
            else if (Percentage >=60)
            {
                Console.WriteLine("Grade: B");
            }
            else if (Percentage >=50)
            {
                Console.WriteLine("Grade: C");
            }
            else if(Percentage >=40)
            {
                Console.WriteLine("Grade: D");
            }
            else if (Percentage >=35)
            {
                Console.WriteLine("Grade: E");
            }
            else
            { 
                Console.WriteLine("Grade: F (Fail) ");
            }
            Console.ReadLine();
        }
    }
}
