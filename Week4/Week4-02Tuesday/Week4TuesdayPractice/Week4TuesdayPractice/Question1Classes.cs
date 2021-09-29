using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4TuesdayPractice
{
    class Question1Classes
    {
        int a;
        int b;
        bool w;
        public double multiply()
        {
            do
            {
                w = false;
                try
                {
                    Console.WriteLine("Input value of a.");
                    a = Int32.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Please input numbers only. {0}", ex.Message);
                    w = true;
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine("Please input numbers only. {0}", ex.Message);
                    w = true;
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("Please input values within the range of -2,147,483,647 to 2,147,483,647. {0}", ex.Message);
                    w = true;
                }
            } while (w == true);
    
            do
            {
                w = false;
                try
                {
                    Console.WriteLine("Input value of b.");
                    b = Int32.Parse(Console.ReadLine());
                    int c = a * b;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Please input numbers only. {0}", ex.Message);
                    w = true;
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine("Please input numbers only. {0}", ex.Message);
                    w = true;
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("Please input values within the range of -2,147,483,647 to 2,147,483,647. {0}", ex.Message);
                    w = true;
                }
            } while (w == true);

            return a * b;
        }

        public double divide()
        {
            do
            {
                w = false;
                try
                {
                    Console.WriteLine("Input value of a.");
                    a = Int32.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Please input numbers only. {0}", ex.Message);
                    w = true;
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine("Please input numbers only. {0}", ex.Message);
                    w = true;
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("Please input values within the range of -2,147,483,647 to 2,147,483,647. {0}", ex.Message);
                    w = true;
                }
            } while (w == true);

            do
            {
                w = false;
                try
                {
                    Console.WriteLine("Input value of b.");
                    b = Int32.Parse(Console.ReadLine());
                    int c = (a / b);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Please input numbers only. {0}", ex.Message);
                    w = true;
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine("Please input numbers only. {0}", ex.Message);
                    w = true;
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("Please input values within the range of -2,147,483,647 to 2,147,483,647. {0}", ex.Message);
                    w = true;
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Please do not input zero value for B. {0}", ex.Message);
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine("Caught", ex.Message);
                }
            } while (w == true);
            return a * b;
        }
    }
}
