using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[2][];
            arr[0] = new int[] { 3, 2 };
            arr[1] = new int[] { 3, 2, 4};
            for (int j = 0; j < 2; j++)
            {
                foreach (int i in arr[j])
                {
                    Console.Write(i);
                }
            }
            Console.ReadLine();
            //Console.WriteLine("Welcome Home + args[0]");
            //string str = add(int.Parse(args[1]), int.Parse(args[2])).ToString();
            //Console.WriteLine(" The addition of two numbers are: " + str);
            //Console.ReadLine();
        }
        //private static int add(int a, int b)
        //{
        //    return a + b; 
        //} */
    }
}
