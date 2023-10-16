using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marksheet_c_sharp_programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Name");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter your Roll.no");
            string roll_no = Console.ReadLine();
            Console.WriteLine("Enter Your Class");
            string standard = Console.ReadLine();
            Console.WriteLine("Enter your Hindi Marks");
            int H = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your English Marks");
            int E = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Marthi Marks");
            int M = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Science Marks");
            int S = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Physics Marks");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Chemistry Marks");
            int C = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Mathmatics Marks");
            int Mm = int.Parse(Console.ReadLine());

            int obt = H+E+M+S+p+C+Mm;
            int per = obt * 100 / 700;

            Console.WriteLine("-------------Marksheet------------");
            Console.WriteLine("Your name is:{0}",Name);
            Console.WriteLine("Your name is:{0}",roll_no);
            Console.WriteLine("Your class is:{0}", standard);
            Console.WriteLine("Your Obtain mark:{0}", obt);
            Console.WriteLine("Your percentage:{0}", per );

            //if else if for Grade
            if(per>=80)
            {
                Console.WriteLine("Grade:A-1");
            }
            else if (per>=70)
            {
                Console.WriteLine("Grade:A");
            }
            else if(per>=60)
            {
                Console.WriteLine("Grade:B");
            }
                else if(per>=50)
            {
                Console.WriteLine("Grade:C");
            }
            else if(per>=40)
            {
                Console.WriteLine("Grade:D");
            }
            else if(per>=35)
            {
                Console.WriteLine("Grade:E");
            }
            else
            { 
                Console.WriteLine("Grade:F (fail)");
            }

            //if else if for remark
            if (per >= 80)
            {
                Console.WriteLine("Remark:Excellent !!");
            }
            else if (per >= 70)
            {
                Console.WriteLine("Remark:Very Good !!");
            }
            else if (per >= 60)
            {
                Console.WriteLine("Remark:Good !!");
            }
            else if (per >= 50)
            {
                Console.WriteLine("Remark:Fair !!");
            }
            else if (per >= 40)
            {
                Console.WriteLine("Remark:Poor !!");
            }
            else if (per >= 35)
            {
                Console.WriteLine("Remark:Needs lot of Improvement !!");
            }
            else 
            {
                Console.WriteLine("Remark:Bring your parents Tomorrow !!");
            }


            int supply = 0;

            //int obt = H + E + M + S + p + C + Mm;

            if (H <= 35)
            {
                supply++;
            }
            if (E <= 35)
            {
                supply++;
            }
            if (M <= 35)
            {
                supply++;
            }
            if (S <= 35)
            {
                supply++;
            }
            if (p <= 35)
            {
                supply++;
            }
            if (C <= 35)
            {
                supply++;
            }
            if (Mm <= 35)
            {
                supply++;
            }

            Console.WriteLine("You are failed in subject {0} ", supply);







            Console.ReadLine();



        }
    }
}
