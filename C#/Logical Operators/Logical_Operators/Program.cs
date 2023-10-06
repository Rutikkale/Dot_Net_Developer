using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AND logical operators

            // condition True && False

            //int a = 50;
            //int b = 40;

            //bool c = (a>b) && (b>a);
            //Console.WriteLine(c);
            //Console.ReadLine();

            // o/p: False


            // condition True && True

            //int a = 50;
            //int b = 40;

            //bool c = (a > b) && (b < a);
            //Console.WriteLine(c);
            //Console.ReadLine();

            //o/p: True

            // condition False && False

            //int a = 50;
            //int b = 40;

            //bool c = (a<b) && (b>a);
            //Console.WriteLine(c);
            //Console.ReadLine();

            //o/p: False
            //Real Time Example: login form id && password


            // OR logical operators

            //condition True || True

            //int a = 50;
            //int b = 40;

            //bool c = (a > b) || (b < a);
            //Console.WriteLine(c);
            //Console.ReadLine();

            //o/p: True


            // condition True || False

            //int a = 50;
            //int b = 40;

            //bool c = (a>b) || (b>a);
            //Console.WriteLine(c);
            //Console.ReadLine();

            //o/p: True

            // condition False || False

            int a = 50;
            int b = 40;

            bool c = (a<b) || (b>a);
            Console.WriteLine(c);
            Console.ReadLine();
           
            //o/p: False
            // RealTime Example: Aadhar Card Or Pan Card or Driving Lincen

         



        }
    }
}
