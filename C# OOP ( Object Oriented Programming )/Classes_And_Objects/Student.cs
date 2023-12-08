using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_And_Objects
{
    internal class Student
    {
        int rollno;
        string name;
        int age;
        int standard;

        public void setStudent(int rollno,string name,int age, int standard)
        { 
            this.rollno = rollno;
            this.name = name;
            this.age = age;
            this.standard = standard;
        }

        public void getStudent()
        {
            Console.WriteLine("Enter student Rollno: {0}",this.rollno);
            Console.WriteLine("Enter student Name: {0}", this.name);
            Console.WriteLine("Enter student Age: {0}",this.age);
            Console.WriteLine("Enter student Class: {0}",this.standard);


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Rollno:");
            int roll = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Your Age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Class");
            int standard = int.Parse(Console.ReadLine());

            ////Object is an instance of a class

            Student Rutik = new Student();
            Rutik.setStudent(roll, name, age, standard);
            Rutik.getStudent();




            //Student Rutik = new Student();
            //Rutik.setStudent(21,"Rutik Kale",22,12);
            //Rutik.getStudent();
            //Console.WriteLine("- - - - - - - - -");

            //Student Arpit = new Student();
            //Arpit.setStudent(22, "Arpit Kale",18, 11);
            //Arpit.getStudent();

            Console.ReadLine();
        }
    }
}
