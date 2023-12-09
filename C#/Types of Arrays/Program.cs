using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types_of_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // single-Dimentional Arrays
            //int[] arr = new int[3];
            //arr[0] = 11;
            //arr[1] = 22;
            //arr[2] = 33;

            //Console.WriteLine(arr[0]);
            //Console.ReadLine();

            // multi-Dimentional arrays
            // Rectangular Multi-dimentional arrays

            //int[,] my_arrays = new int[3, 4]
            //{
            //    {11,12,13,14 },
            //    {21,22,23,24 },
            //    {31,32,33,34 }

            //};

            //for (int i = 0; i < my_arrays.GetLength(0); i++)
            //{


            //    for (int j = 0; j < my_arrays.GetLength(1); j++)
            //    {
            //        Console.Write(my_arrays[i, j] + " ");
            //    }

            //    Console.WriteLine();  
            //}

            //Console.ReadLine();



            //jadded Multi-dementional arrays
            // foreach neasted loop jadded multi-dementional arrays

            //int[][] My_array1 = new int[3][];
            //My_array1[0] = new[] { 11, 22, 33, 44, 55, 66, 77, 88 };
            //My_array1[1] = new[] { 21, 22, 23, 24, 25, 26, 27 };
            //My_array1[2] = new[] { 31, 32, 33, 34, 35, 36 };


            //foreach (int[] arr in My_array1)
            //{
            //    foreach (int item in arr)
            //    {
            //        Console.WriteLine(item + "");
            //    }
            //}

            //Console.ReadLine();


            //jadded Multi-dementional arrays
            // for neasted loop jadded multi-dementional arrays

            int[][] My_array1 = new int[3][];

            My_array1[0] = new[] { 11, 22, 33, 44, 55, 66, 77, 88, 99 };
            My_array1[1] = new[] { 21, 22, 23, 24, 25, 26, 27, 28 };
            My_array1[2] = new[] { 31, 32, 33, 34, 35, 36, 37 };

            for (int i = 0;  i < My_array1.GetLength(0); i++)
            {
                for (int j = 0; j < My_array1[i].Length  ; j++)
                {
                    Console.WriteLine(My_array1[i][j]+"");
                }
                Console.WriteLine();
            }
            Console.ReadLine();


        }
    }
}
