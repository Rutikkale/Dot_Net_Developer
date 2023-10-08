using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Precedence_of_operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 8 / 2 - (3 + 2) * 2;

            // 8/2-5*2
            //4-5*2
            //4-10
            //-6

            Console.WriteLine(a);
            Console.ReadLine();
            
            // highest level-- (),/,*,+,-
            // BODMAS Rules6


            //o/p: -6
        }
    }
}
