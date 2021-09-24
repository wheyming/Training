using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3FridayDemonstration
{
    class Program
    {
        private static void jagged_Array()
        {
            int[][] jagged_arr = new int[4][];

            jagged_arr[0] = new int[2] { 5, 10 };
            jagged_arr[1] = new int[] { 10 , 20 , 30 };
            jagged_arr[2] = new int[1] { 40 };
            jagged_arr[3] = new int[5] { 50, 60, 70, 80, 90 };


            int[][] jagged_arr1 = new int[][]
            {
                new int[]{1, 2, 3 },
                new int[]{4, 5, 6, 7}
            };


            int[][,] jagged_arr_1 = new int[2][,]
            {
                new int[,]{ { 1 , 3 } , { 5 , 7 } },
                new int[,]{ { 2, 4} , { 6 , 10 } , { 11 , 12 } } 
            };


            int[,] arr1 = new int[3, 4];


            for (int i = 0; i < jagged_arr_1.Length; i++)
            {
                int x = 0;
                for (int j = 0; j < jagged_arr_1[i].GetLength(x); j++)
                {
                    for (int k = 0; k < jagged_arr_1[j].Rank; k++) // when j == 2 error.
                    {

                        Console.WriteLine($"Jagged Array Element {i} {j} {k} is {jagged_arr_1[i][j , k]}");
                    }
                }
                x++;
                Console.WriteLine();
            }


            for (int i = 0; i < jagged_arr.Length; i++)
            {
                for (int j = 0; j < jagged_arr[i].Length; j++)
                {
                    Console.WriteLine($"Jagged Array Element {i} {j} is {jagged_arr[i][j]}");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            jagged_Array();

            //unary operator - Complement operator
            uint f = 5;
            Console.WriteLine("f :" + Convert.ToString(f, toBase: 2));
            Console.WriteLine("Result :" + Convert.ToString(~f, toBase: 2));


            //Bitwise operator
            uint a = 248;
            uint b = 28;

            uint andoperation = a & b;
            uint oroperation = a | b;
            uint xoroperation = a ^ b;

            Console.WriteLine($"The and operation of {Convert.ToString(a, toBase: 2)} and {Convert.ToString(b, toBase: 2)} is {Convert.ToString(andoperation, toBase: 2)}");
            Console.WriteLine($"The or operation of {Convert.ToString(a, toBase: 2)} and {Convert.ToString(b, toBase: 2)} is {Convert.ToString(oroperation, toBase: 2)}");
            Console.WriteLine($"The xor operation of {Convert.ToString(a, toBase: 2)} and {Convert.ToString(b, toBase: 2)} is {Convert.ToString(xoroperation, toBase: 2)}");
            Console.ReadLine();

            //Shift operator
            uint c = 10;
            uint leftshift = c << 2; // result will be c * ( 2 * leftshiftnumberoftimes)
            Console.WriteLine($"Result of left shift of {Convert.ToString(c, toBase: 2)} of 2 times is {Convert.ToString(leftshift, toBase: 2)}.");

            uint rightshift = c >> 2; // result will be c / ( 2 * rightshiftnumberoftimes)
            Console.WriteLine($"Result of right shift of {Convert.ToString(c, toBase: 2)} of 2 times is {Convert.ToString(rightshift, toBase: 2)}.");

            Console.ReadLine();

            a = 10;
            b = 20;
            c = 30;
            uint d = 40;

            var res = ~d | b ^ a & c; //Remember about operator precedence!!

            var res1 = ~d;
            var res2 = a & c;
            var res3 = b ^ res2;
            var res4 = res1 | res3;

            Console.WriteLine(Convert.ToString(a, toBase: 2) + "\n" +  Convert.ToString(b, toBase: 2) + "\n" + Convert.ToString(c, toBase: 2) + "\n" + Convert.ToString(d, toBase: 2) + "\n" + Convert.ToString(res , toBase : 2));

            Console.WriteLine(Convert.ToString(a, toBase: 2) + "\n" + Convert.ToString(b, toBase: 2) + "\n" + Convert.ToString(c, toBase: 2) + "\n" + Convert.ToString(d, toBase: 2) + "\n" + Convert.ToString(res4, toBase: 2));
            Console.ReadLine();



        }
    }
}
