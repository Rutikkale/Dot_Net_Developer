using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Types_of_Inheritance
{
    // 1) single inheritance 

    /* 

     class BaseClass
     {
         public void show1()
         {
             Console.WriteLine("This is the method of base class!!");
         }
     }
     class DerivedClass:BaseClass
     {
         public void show2()
         {
             Console.WriteLine("This is the method of Derived class!!");
         }
     } 

     */

    // 2) Hierarchical inheritance:
    /*
    class BaseClass
    {
        public void show()
        {
            Console.WriteLine("This is the method of Base class !!");
        }
    }

    class DerivedClass1: BaseClass
    {
        public void show1()
        {
            Console.WriteLine("This is the method of 1st Derived class !!");
        }
    }

    class DerivedClass2 : BaseClass
    {
        public void show2()
        {
            Console.WriteLine("This is the method of 2st Derived class !!");
        }
    }
    */

   // 3) Multilevel Inheritance 

    class BaseClass // Grand Father
    {
        public void show()
        {
            Console.WriteLine("This is the method for BaseClass !!");
        }

    }

    class DerivedClass1: BaseClass // father Parents
    {
        public void Show1()
        {
            Console.WriteLine("This is the method for DerivedClass1 !!");
        }
    }

    class DerivedClass2 : DerivedClass1 // Child
    {
        public void Show2()
        {
            Console.WriteLine("This is the method for DerivedClass2 !!");
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            // 1) single inheritance  
            /*
             
            DerivedClass dc = new DerivedClass();
            dc.show1();
            dc.show2();
            Console.ReadLine();

            */

            // 2) Hierarchical inheritance:
            /*
                        DerivedClass1 dc1 = new DerivedClass1();
                        dc1.show();
                        dc1.show1();
                        Console.WriteLine("-------------------------------------------------");
                        DerivedClass2 dc2 = new DerivedClass2();
                        dc2.show();
                        dc2.show2();
                        Console.ReadLine();
            */

          //  3) Multilevel Inheritance

            DerivedClass1 dc1 = new DerivedClass1();
            dc1.show();
            dc1.Show1 ();

            Console.WriteLine("-----------------------------");

            
            
            DerivedClass2 dc2 = new DerivedClass2();
            dc2.show();
            dc2.Show1();
            dc2.Show2 ();

            Console.WriteLine("-----------------------------");



            DerivedClass3 dc3 = new DerivedClass3();
            dc3 .show();
            dc3.Show1 ();
            dc3 .Show2 ();
            dc3.Show3 ();    
            
            Console.ReadLine();


        }
    }
}
