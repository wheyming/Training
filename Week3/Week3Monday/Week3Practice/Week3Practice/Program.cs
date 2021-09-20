using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate Calculator = new Calculate();
            Console.WriteLine("a: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("b: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Which operation would you like to perform?");
            Console.WriteLine("1. Addition\n2. Subtraction\n3. Multiplication\n4. Division");
            int c = Int32.Parse(Console.ReadLine());
            if (c == 1)
            {
                Console.WriteLine(Calculator.addition(a, b));
            }
            else if (c == 2)
            {
                Console.WriteLine(Calculator.subtraction(a, b));
            }
            else if (c == 3)
            {
                Console.WriteLine(Calculator.multiplication(a, b));
            }
            else if (c == 4)
            {
                Console.WriteLine(Calculator.division(a, b));
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
            
            Console.ReadLine();
        }
    }
}
