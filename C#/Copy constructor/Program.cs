using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_constructor
{
    class Example
    {
        string name;
        int age;

        public Example(string name,int age)
        {
            this.name = name;
            this.age = age;
        }

        public Example(Example e) // Copy constructor
        {
            this.name = e.name;
            this.age = e.age;
        }
        public void getData()
        {
            Console.WriteLine("Name is:{0}",name);
            Console.WriteLine("Age is:{0}", age);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Example obj = new Example("Rutik",23);
            obj.getData();
            Example obj1 = new Example(obj);// called copy constructor
            obj1.getData();
            Console.ReadLine();

        }
    }
}
