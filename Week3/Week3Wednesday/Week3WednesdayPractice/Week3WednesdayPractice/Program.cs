using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3WednesdayPractice
{
    

    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            int count = 0;

            bool w = true;
            while (w == true)
            {
                Console.WriteLine("0: End Program\n1: Addition\n2: Subtraction");
                int input = Int32.Parse(Console.ReadLine());
                if (input == 1)
                {
                    Console.WriteLine("Key in value for x");
                    x = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Key in value for y");
                    y = Int32.Parse(Console.ReadLine());
                    Calculation calplus = new Calculation(Calculatorclasses.Add);
                    Console.WriteLine(x + " + " + y + " = " + calplus(x, y) + "\n");
                    count++;
                }
                if (input == 2)
                {
                    Console.WriteLine("Key in value for x");
                    x = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Key in value for y");
                    y = Int32.Parse(Console.ReadLine());
                    Calculation calminus = new Calculation(Calculatorclasses.Sub);
                    Console.WriteLine(x + " - " + y + " = " + calminus(x, y) + "\n");
                    count++;
                }
                if (input == 0)
                {
                    w = false;
                }
            }
            Console.WriteLine("Total operations done: " + count);
            Console.ReadLine();
        }

    }
}
