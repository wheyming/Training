using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorClass Cal = new CalculatorClass();

            bool w = true;
            while (w == true)
            {
                Console.WriteLine("0: End Program\n1: Addition\n2: Subtraction");
                int input = Int32.Parse(Console.ReadLine());
                if (input == 1)
                {
                    Console.WriteLine("Key in value for x");
                    Cal.x = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Key in value for y");
                    Cal.y = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(Cal.x + " + " + Cal.y + " = " + Cal.addition() + "\n");
                }
                if (input == 2)
                {
                    Console.WriteLine("Key in value for x");
                    Cal.x = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Key in value for y");
                    Cal.y = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(Cal.x + " - " + Cal.y + " = " + Cal.subtraction() + "\n");
                }
                if (input == 0)
                {
                    w = false;
                }
            }
            Console.WriteLine("Total operations done: " + (Cal.Counter() - 1));
            Console.ReadLine();
        }

    }
}
