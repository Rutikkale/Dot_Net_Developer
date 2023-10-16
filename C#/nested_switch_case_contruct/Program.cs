using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nested_switch_case_contruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your pizz flavour");
            string pizza = Console.ReadLine();

            switch (pizza)
            {
                case "Fajita":
                    Console.WriteLine("You have selected Fajita pizz");
                    break;

                case "Supreme":
                    Console.WriteLine("You have selected Supreme pizz");
                    break;

                case "Cheese":
                    Console.WriteLine("You have selected Cheese pizz");
                    break;

                case "Vegetable":

                   Console.WriteLine("You have selected Vegetable pizz");
                    string veg = Console.ReadLine();
                    switch(veg)
                    {
                        case "Olives":
                            Console.WriteLine("you have selected olives in your veg pizz");
                            break;

                        case "Onions":
                            Console.WriteLine("you have selected Onions in your veg pizz");
                            break;

                        case "Mushroom":
                            Console.WriteLine("you have selected Mushroom in your veg pizz");
                            break;

                        default:
                            Console.WriteLine("Vegetable not available");
                            break;
                            
                        
                        
                    }
                    break;

                default:
                    Console.WriteLine("Pizz flavour not available");
                    break;

                    
                 }
            Console.ReadLine();
            }
        
        }
    }
