using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4TuesdayPractice
{
    class Question4Classes
    {
        private int[] Q4arr = new int[10];

        public int this[int index]
        {
            get
            {
                try
                {
                    return Q4arr[index];
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine("Invalid index value. {0}", ex.Message);
                }
                return 0;
            }
            set
            {
                try
                {
                    Q4arr[index] = value;
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine("Invalid index value. {0}", ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Please input integers only. {0}", ex.Message);
                }
            }
        }

        public void indexerMethod()
        {
            Question4Classes Q4 = new Question4Classes();
            bool w = true;
            do
            {
                try
                {
                    Console.WriteLine("Would you like to end(0), set(1) or get(2) values in the array?");
                    int inputQ4 = int.Parse(Console.ReadLine());
                    if (inputQ4 == 0)
                    {
                        w = false;
                    }
                    else if (inputQ4 == 1)
                    {
                        Console.WriteLine("Which index would you like to set in?");
                        int inputQ4_1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("What value would you like to set in the index {0}", inputQ4_1);
                        int inputQ4_2 = int.Parse(Console.ReadLine());
                        Q4[inputQ4_1] = inputQ4_2;
                    }
                    else if (inputQ4 == 2)
                    {
                        Console.WriteLine("Which index would you like to get the values in?");
                        int inputQ4_3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("The value of index {0} is {1}.", inputQ4_3, Q4[inputQ4_3]);
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Please input integers only.");
                }
            } while (w == true);
        }
    }
}
