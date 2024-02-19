using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_Constructor
{
    class Example
    {
        public string Name;
        public string Fname;

        public static int a;

     private Example()
      { 
        
      }

        private Example(int a)
        {

        }

        //public Example()
        //{ }

        public Example(string name,string Fname)
        {
            this.Name = name;
            this.Fname = Fname;
        }

        //class Example2 :Example 
        //{

        //}

        public static int GetIncrement()
        {
        return ++a;
        }
        public static void GetTime()
        {
            Console.WriteLine(DateTime.Now);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example e = new Example();
            Example e = new Example("Rutik ","Kale");
            Console.WriteLine(e.Name + e.Fname);

            Example.GetTime();
            Example.a = 23;
            Console.WriteLine(Example.GetIncrement());
            

            
            Console.ReadLine();
        }
    }
}
