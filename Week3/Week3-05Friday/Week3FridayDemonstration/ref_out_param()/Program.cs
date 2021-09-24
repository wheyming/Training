using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref_out_param__
{
    class Program     
    {
        private static void swap(int c, int d) // pass by value
        {
            int temp = c;
            c = d;
            d = temp;
        }

        private static void swapbyref(ref int c, ref int d) // pass by reference
        {
            int temp = c;
            c = d;
            d = temp;
        }
        
        private static void ref_out_param()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine("Before swapping");
            Console.WriteLine("a : " + a);
            Console.WriteLine("b : " + b);

            swap(a, b);
            Console.WriteLine("After swapping by value");
            Console.WriteLine("a : " + a);
            Console.WriteLine("b : " + b);

            swapbyref(ref a, ref b);
            Console.WriteLine("After swapping by reference");
            Console.WriteLine("a : " + a);
            Console.WriteLine("b : " + b);
        }

        private static void param_method()
        {
            printParameters(1, 2, 3, 4);

            int[] intarr = new int[] { 5, 6, 7, 8, 9 };
            object[] objarr = new object[] { 5, 6, 7, 8, 9 };
            printParameters(100, 120, intarr);
            printParameters1(objarr);
            //printParameters1(intarr); // allowed, C# will implicit convert int to object.
            //printParameters(objarr); // Not allowed, no implicit convertion from int to object.
        }

        private static void printParameters(int a, int b, params int[] arr)
        {
            Console.WriteLine($"a is {a}");
            Console.WriteLine($"b is {b}");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"List element {i} is {arr[i]}.");
            }
        }

        private static void printParameters1(params object[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"List element {i} is {arr[i]}.");
            }
        }

        private static void out_param_modifier()
        {
            object obj = 25;
            var boolresult = isvalidInt(obj, out int res, out int res1);
            Console.WriteLine(boolresult);
            Console.WriteLine(res);
            Console.WriteLine(res1);
        }

        private static bool isvalidInt(object s, out int res, out int res1)
        {
            if(s is int)
            {
                res1 = 10;
                res = (int)s;
                return true; // return must be last line, as anything after will not be executed.
            }
            res = -1;
            res1 = 10;
            return false; // return must be last line, as anything after will not be executed.
        }

        static bool methodA(out int result, params int[] intarr1)
        {
            result = intarr1[0] - intarr1[1];
            if (result < 0)
            {
                return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine(methodA(out int res, a, b));
            Console.WriteLine(res);

            out_param_modifier();

            param_method();
            ref_out_param();
            Console.ReadLine();
        }
    }
}
