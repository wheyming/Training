using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4TuesdayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Int32.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    {
                        Console.WriteLine("Question 1");
                        Question1Classes Q1 = new Question1Classes();
                        try
                        {
                            Console.WriteLine("Would you like to Multiply(Press 1) or Divide(Press 2)?");
                            char inputQ1 = Convert.ToChar(Console.ReadLine());
                            if (inputQ1 == '1')
                            {
                                Console.WriteLine(Q1.multiply());
                            }
                            else if (inputQ1 == '2')
                            {
                                Console.WriteLine(Q1.divide());
                            }
                            Console.ReadLine();
                        }
                        catch (FormatException ex)
                        {

                        }
                        break;
                    }

                case 2:
                    {

                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Question 3");
                        Question3Classes Q3 = new Question3Classes();
                        bool w = true;
                        do
                        {
                            Console.WriteLine("\nWould you like to Push(Press 1), Pop(Press 2) or end(Press 3)?");
                            int Q3i = Int32.Parse(Console.ReadLine());
                            if (Q3i == 1)
                            {
                                Q3.pushStack();
                            }
                            else if (Q3i == 2)
                            {
                                Q3.popStack();
                            }
                            else if (Q3i == 3)
                            {
                                w = false;
                            }
                            else
                            {
                                Console.WriteLine("Incorrect input.");
                            }
                            foreach (var item in Question3Classes.Q3Stack)
                            {
                                Console.Write(item + " ");
                            }
                        } while (w == true);
                        break;
                    }
                case 4:
                    {
                        Question4Classes Q4main = new Question4Classes();
                        Q4main.indexerMethod();
                        break;
                    }
                case 5:
                    {
                        Question5Classes Q5main = new Question5Classes();
                        Console.WriteLine("Would you like to access information by name(1) or ID(2)?");
                        int input5 = int.Parse(Console.ReadLine());
                        if (input5 == 1)
                        {
                            Console.WriteLine("Please input name");
                            string input5_name = Console.ReadLine();
                        }
                        Console.ReadLine();
                        break;
                    }
            }
        }
    }
}
