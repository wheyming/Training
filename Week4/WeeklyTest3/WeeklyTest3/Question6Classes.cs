using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyTest3
{
    class Question6Classes
    {
        int[] Q6 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public void getElement(int i)
        {
            try
            {
                Console.WriteLine($"The element in index {i} is {Q6[i]}");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index provided does not exist.");
            }
            catch (Exception)
            {
                Console.WriteLine("Incorrect input");
            }
        }

        public void division(int a, int b)
        {
            try
            {
                Console.WriteLine($"The divison of {a} and {b} is {a / b}.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("The value of b cannot be 0.");
            }
            catch (Exception)
            {
                Console.WriteLine("Incorrect input");
            }
        }
        public void calculate(string input, int index)
        {
            try
            {
                Console.WriteLine($"The string is {input.Length} long and the character at index {index} is {input[index]}");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("The inputs cannot be null.");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("The index value exceeds the length of the string.");
            }
            catch (Exception)
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
