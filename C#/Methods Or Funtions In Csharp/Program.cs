using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Or_Funtions_In_Csharp
{
    internal class Program
    {
        //public void show() //Declaring a Method // Non- static // instance Method // Non-parameterized method
        //{
        //    Console.WriteLine("Welcome To The C# Programming...");
        //    Console.WriteLine("hey bro wassup..");

        //}


        //public static void show1() //Declaring a Method // static method // instance Method // Non-parameterized method
        //{
        //    Console.WriteLine("Welcome To The C# Programming...");
        //    Console.WriteLine("hey bro wassup..");

        //}

        //public static void Add(int num1,int num2) //Parameterized method //Declaring a Method // static method 
        //{
        //    int Result = num1 + num2;
        //    Console.WriteLine("Your Additional Result is:"+Result);

        //}


        //public static void username(string username = "Unknown") //Default value or Optional parameters
        //{
        //    Console.WriteLine("Your name is:" + username);
        //}


        //public static void show_name_age(string name, int age)
        //{
        //    Console.WriteLine( "Your name is: "+ name);
        //    Console.WriteLine("Your age is: " + age);

        //}

        public static int add(int num1, int num2)
        { 
           int result= num1 + num2;
            return result;
        }


        static void Main(string[] args)
        {
            int a = Program.add(20, 30);
            int b = 20;
            int c = a + b;
            Console.WriteLine(c);


            // Console.WriteLine(Program.add(10,20));// calling method


            //Program.show_name_age("Rutik", 23 );
            //Program.show_name_age(age: 23, name: "Rutik"); //named arguments


            //Program.username();
            // Program.username("rutik");

            //Console.WriteLine("Enter your Frist Number:");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter your Second Number:");
            //int b = int.Parse(Console.ReadLine());

            //Program.Add(a,b);


            //Program.Add(10, 20); // arguments // calling funtion
            //Program.Add(20, 30);
            //Program.Add(30, 40);




            // Program.show1();// calling funtion



            //Program p1 = new Program();
            //p1.show(); //Call 



            Console.ReadLine();
        }
    }
}
