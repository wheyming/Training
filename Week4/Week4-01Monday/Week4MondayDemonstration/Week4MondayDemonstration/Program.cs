using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4MondayDemonstration
{
    class Program
    {


        private static void ExceptionHandling()
        {
            while (true)
            {
                try
                {
                    int a = Int32.Parse(Console.ReadLine());    // Will break after error, so next line will not be executed if there is error.
                    int res = a / 0;
                    Console.WriteLine($"User entered number {a}");
                    int[] b = new int[5] { 1, 2, 3, 4, 5 };
                    for(int i = 0; i <= 5; i ++)
                    {
                        Console.WriteLine($"Array element {b[i]}");
                    }
                    object obj = 12;
                    string str = (string)obj; // InvalidCastException
                    Console.WriteLine("Successfully executed try block");

                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Exception raised {ex.Message}");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Exception raised {ex.Message}");
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine($"Exception raised {ex.Message}");
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine($"Exception raised {ex.Message}");
                }
                catch (InvalidCastException ex)
                {
                    Console.WriteLine($"Exception raised {ex.Message}");
                }
                catch (Exception ex) // General Exception, must be at the end of the other exceptions, if not error will occur for subsequent catch exceptions.
                {
                    /* if(ex is IndexOutOfRangeException)
                    {

                    } */
                    Console.WriteLine($"Exception raised {ex.Message}");
                }
                finally // Always runs at the end.
                {
                    Console.WriteLine("Running finally block");
                }
            }
        }

        private static void ExceptionDivision(int a, int b)
        {
            try
            {
                Console.WriteLine($"The result of {a} divided by {b} is : {a / b}.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot be divided by zero, please try again.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter integers only.");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Please enter integers within the range of -2147483647 and 2147483647 only");
            }
            catch(Exception ex)
            {
                Console.WriteLine("An exception has occured.");
            }
            finally
            {
                Console.WriteLine("One iteration has passed.");
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Please enter input 1: ");
            int input1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter input 2: ");
            int input2 = Int32.Parse(Console.ReadLine());
            ExceptionDivision(input1, input2);

            //ExceptionHandling();
            Console.ReadLine();
        }
    }
}
