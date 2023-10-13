using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case_construct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int week_number = 2;
            switch(week_number)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                    case 2:
                    Console.WriteLine("Tuesday");
                    break;
                    case 3:
                    Console.WriteLine("Wednesday");
                    break;
                    case 4:
                    Console.WriteLine("Thursday");
                    break;
                    case 5:
                    Console.WriteLine("Friday");
                    break;
                    case 6:
                    Console.WriteLine("Saturday");
                    break;
                    case 7:
                    Console.WriteLine("Sunday");
                    break;
                    default: Console.WriteLine("Invalid Week Number");
                    break;

            }

            Console.WriteLine("After switch statement");
            Console.ReadLine();
        }
    }
}
