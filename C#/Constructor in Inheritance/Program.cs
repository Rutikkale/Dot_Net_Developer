using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_in_Inheritance
{
    // 1) Non Parameteries Constructor in Inheritance
    /*
     
     class BaseClass
    {
public BaseClass()
        {
            Console.WriteLine("This is the constructor of BaseClass !!");
        }
    }
    class DerivedClass : BaseClass
    {
        public DerivedClass()
        {
            Console.WriteLine("This is the Construtor of DerivedClass !!");
        }
    }
    */

    // 2) Parameteries Construtor In Inheritance

    class BaseClass
    {
        public BaseClass(string message)
        {
            Console.WriteLine(message);
        }
    }

    class DerivedClass : BaseClass
    {
        public DerivedClass(): base("This is the Construtor of BaseClass!!")
        {
            Console.WriteLine("This is the Construtor of DerivedClass!!");
        }
       
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1) Non Parameteries Constructor in Inheritance
            /*
            DerivedClass dc = new DerivedClass();
            Console.ReadLine();
            */

            // 2) Parameteries Construtor In Inheritance
            DerivedClass dc = new DerivedClass();
            Console.ReadLine(); 
        }
    }
}
