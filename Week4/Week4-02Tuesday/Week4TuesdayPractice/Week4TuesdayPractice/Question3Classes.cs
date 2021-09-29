using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4TuesdayPractice
{
    class Question3Classes
    {
        public static Stack<int> Q3Stack = new Stack<int>();

        public void pushStack()
        {
            try
            {
                Console.WriteLine("Which integer would you like to push?");
                int Q3A = Int32.Parse(Console.ReadLine());
                Q3Stack.Push(Q3A);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please input integers only. {0}", ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Please input integers only. {0}", ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Please input integers only. {0}", ex.Message);
            }
        }
        public void popStack()
        {
            try
            {
                Console.WriteLine($"{Q3Stack.Peek()} is removed.");
                Q3Stack.Pop();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("There is nothing left in the stack. {0}", ex.Message);
            }
        }
    }
}
