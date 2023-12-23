using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creating_Calculator_Application
{
    internal class Program
    {
        public static void addition(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Addition Result Is: {0}",result);
        }

        public static void Substraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Substraction Result Is: {0}", result);
        }

        public static void Multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("Multiplication Result Is: {0}", result);
        }

        public static void Division(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("Division Result Is: {0}", result);
        }

        static void Main(string[] args)
        {
            // How to create a calculator application
            // Methods
            // Decision Making Statements If Else If


            Console.WriteLine("Enter Your Frist Number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Second Number:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Operator (+, -, *, /)");
            string op = Console.ReadLine();

            if (op.Equals("+"))
            {
                Program.addition(num1, num2);
            }
            else if (op.Equals("-"))
            {
                Program.Substraction(num1, num2);
            }
            else if (op.Equals("*"))
            {
                Program.Multiplication(num1, num2);
            }
            else if (op.Equals("/"))
            {
                Program.Division(num1, num2);
            }
            else
            {
                Console.WriteLine("Invalid Operators..!!");
            }
           

            Console.ReadLine();
        }
    }
}
