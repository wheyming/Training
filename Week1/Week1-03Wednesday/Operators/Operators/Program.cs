using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int x = 25;
            int y = 21;
            x += 3;
            Console.WriteLine(x + y);
            Console.WriteLine(x % y);
            Console.WriteLine((x - 4) == y);
            Console.WriteLine((4 * x) > 100);
            Console.ReadLine();
            

            int x = 20;

            if (x > 100)
            {
                Console.WriteLine("x is more than 100!");
            }
            else if (x == 25)
            {
                Console.WriteLine("x is 25.");
            }
            else
            {
                Console.WriteLine("x is less than 100.");
            }
            Console.ReadLine();
            

            int x = 4;

            switch(x)
            {
                case 1:
                    Console.WriteLine("x is 4");
                    break;
                case 2:
                    Console.WriteLine("x is greater than 3");
                    break;
                case 3:
                    Console.WriteLine("x is greater than 5");
                    break;
                case 4:
                    Console.WriteLine("x is 4");
                    break;
                case 5:
                    Console.WriteLine(" x is 100");
                    break; 

            int x = 4;
            switch(x)
            {
                case 1:
                    Console.WriteLine("Today is Monday");
                    break;
                case 2:
                    Console.WriteLine("Today is Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Today is Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Today is Thursday");
                    break;
                case 5:
                    Console.WriteLine("Today is Friday");
                    break;
                default:
                    Console.WriteLine("Today is a weekend");
                    break;
            }

            int x = 6;
            int y = 10;
            
            while( x > y )
            {
                Console.WriteLine(x);
                x++;
            }

            for (int z = 1; z < 9999; z++)
            {
                if (z <= 5000)
                {
                    Console.WriteLine("z is 5000");
                    if ( z == 10)
                    {
                        break;
                    }
                }
            }

            for ( int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            for ( int i = 0; i < 20; i++)
            {
                if (i == 2)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();
            */

            decimal x = 50.0m;
            decimal y = 12.0m;
            if (x == 50.0m)
            {
                Console.WriteLine($"There is a remainder of {(x % y)}");
            }

            x = 5;
            do
            {
                x++;
                Console.WriteLine(x);
            } while (x < 5);
            Console.ReadLine();
        }
    }
}
