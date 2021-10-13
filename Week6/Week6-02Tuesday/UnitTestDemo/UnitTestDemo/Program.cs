using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First Integer: ");
            string integer1 = Console.ReadLine();
            Console.WriteLine("Enter the Second Integer: ");
            string integer2 = Console.ReadLine();
            int a = int.Parse(integer1);
            int b = int.Parse(integer2);
            Calculator calc = new Calculator();
            Console.WriteLine("Addition: " + calc.Addition(a, b));
            Console.WriteLine("Subtract: " + calc.Subtract(a, b));
            Console.WriteLine("Multiply: " + calc.Multiply(a, b));
            Console.WriteLine("Divide: " + calc.Divide(a, b));

            Console.ReadLine();
        }
    }
}
