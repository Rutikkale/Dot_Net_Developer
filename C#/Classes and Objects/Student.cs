using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects
{
    internal class Student
    {
        // Example 1

        //int rollno;
        //string name;
        //int age;
        //int standard;

        //public void setRollno(int rollno)
        //{
        //   this.rollno = rollno;
        //}

        //public int getRollno()
        //{
        //    return this.rollno;
        //}

        // Example 2 and 3

        int rollno;
        string name;
        int age;
        int standard;

        public void setStudent(int rollno,string name, int age, int standard)
        { 
            this.rollno = rollno;
            this.name = name;
            this.age = age;
            this.standard = standard;
        
        }

        public void getStudent()
        {
            Console.WriteLine("your Roll no is: {0}",this.rollno);
            Console.WriteLine("your name is: {0}", this.name);
            Console.WriteLine("your age is:{0}",this.age);
            Console.WriteLine("your class is: {0}", this.standard);

        }
        


        static void Main(string[] args)
        {

            // Example 1

            //Student rutik = new Student();
            //rutik.setRollno(22);
            //Console.WriteLine(rutik.getRollno()); 

            //Console.ReadLine();

            // Example 2
            // Object is an instance of a class

            //Student rutik = new Student();
            //rutik.setStudent(22, "Rutik kale", 23, 12);
            //rutik.getStudent();

            //Console.WriteLine("----------------------------------------------------");

            //Student arpit = new Student();
            //arpit.setStudent(21, "Arpit kale", 18, 10);
            //arpit.getStudent();

            //Console.ReadLine();


            // Example 3

            // From user input

            Console.WriteLine("Enter your Roll no:");
            int rollno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Your Age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Class:");
            int standard = int.Parse(Console.ReadLine());

            Student rutik = new Student();
            rutik.setStudent(rollno, name, age, standard);
            rutik.getStudent();

            Console.ReadLine();

        }
    }
}
