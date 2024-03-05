using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_class
{
    static class product
    {
        public static int ProductId;
        public static string ProductName;
        public static int ProductPrices;

        static product()
        {
            ProductId = 111;
            ProductName = "Guitar";
            ProductPrices = 5000;

        }

       public  static void getProductDetails()
        {
            Console.WriteLine("ProductId :{0}",ProductId);
            Console.WriteLine( "ProductName : {0}", ProductName);
            Console.WriteLine("ProductPrices: {0}",ProductPrices);
        }

        public static void getProductDiscount()
        {
            int d_amount = ProductPrices / 10;
            Console.WriteLine("Your discount amount is {0}",d_amount);
            Console.WriteLine("Total cost of Product is :{0}",(ProductPrices - d_amount));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            product.getProductDetails();
            product.getProductDiscount();
            Console.ReadLine();
        }
    }
}
