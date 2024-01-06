using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref_And_Out_Keywords
{
    internal class Program
    {    // Example 1

        //public static void PassByValue(int a)
        //{
        //    a = a + 10;
        //    Console.WriteLine("Value is:{0}",a);
        //}

        // Example 2

        //public static void PassByRef(ref int a)
        //{
        //    a = a + 10;
        //    Console.WriteLine("Value is:"+a);
        //}

        // Example 3

        public static void PassBYOut(out int a)
        {
            a = 20;
            Console.WriteLine("value is:{0}",a);
        }
        static void Main(string[] args)
        {
            // Example 1
            //int value = 5;
            //PassByValue(value);//15 calling method
            //Console.WriteLine(value);//5
            //Console.ReadLine();

            // Example 2

            //int value = 5;
            //PassByRef(ref value);// 15
            //Console.WriteLine(value);//15
            //Console.ReadLine();

            // Example 3

            int value;
            PassBYOut(out value);//20
            Console.WriteLine(value);//20
            Console.ReadLine();
            
        }
    }
}
