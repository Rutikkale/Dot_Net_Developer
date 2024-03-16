using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructors
{
    class Person
    {
        public string Name;
        public int Age;

        public Person(string Name, int Age)
        { 
            this.Name = Name;
            this.Age = Age;
        }

        public string getName()
        {
            return Name;

        }
        public int getAge()
        {
            return Age;
        }

        ~Person()
        {
            Console.WriteLine("Destructor has been Invoked");
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person rutik = new Person("Rutik", 23);
            Console.WriteLine(rutik.getName());
            Console.WriteLine(rutik.getAge());
            Console.WriteLine("--------------------------------------");
            Person arpit = new Person("Arpit", 18);
            Console.WriteLine(arpit.getName());
            Console.WriteLine(arpit.getAge());

            // Console.ReadLine(); used ctrl + F5 for run the program in Destructor used 
        }
    }
}
