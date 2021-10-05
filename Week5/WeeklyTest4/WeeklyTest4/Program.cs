using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WeeklyTest4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Toh Wei Ming                Weekly Test 4");
            bool w = true;
            bool Q1bool = true;
            bool Q2bool = true;
            while (w == true)
            {
                Console.WriteLine("\nPlease key the number(1 to 4) for which you would like to view or alternatively, 5 to end the program.");
                int input = Int32.Parse(Console.ReadLine());
                switch (input)
                {


                    case 1:
                        {
                            while (Q1bool == true)
                            {
                                Console.WriteLine("Question 1 Weekly Test 4");
                                Console.WriteLine("Would you like to:" +
                                    "\n1.)Create a thread?" +
                                    "\n2.)Destroy a thread?" +
                                    "\n3.)Check how many threads are running?" +
                                    "\n4.)Make a thread run synchronously?" +
                                    "\n5.)Make a thread sleep for a specific number of seconds?" +
                                    "\n6.)End the program.");
                                int inputQ1A = Int32.Parse(Console.ReadLine());
                                switch (inputQ1A)
                                {
                                    case 1:
                                        {
                                            
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.WriteLine("Please key in thread ID to destroy.");
                                            
                                            break;
                                        }
                                    case 6:
                                        {
                                            Q1bool = false;
                                            break;
                                        }
                                }
                            }
                            break;
                        }



                    case 2:
                        {
                            Q2Class1 Q2int = new Q2Class1();
                            Q2Class2 Q2string = new Q2Class2();
                            Q2Class3 Q2list = new Q2Class3();
                            while (Q2bool == true)
                            {
                                Console.WriteLine("Question 2 Weekly Test 4");
                                Console.WriteLine("Would you like to:" +
                                    "\n1.)Add two integers?" +
                                    "\n2.)Concatenate two strings?" +
                                    "\n3.)Join two lists?" +
                                    "\n4.)End program");
                                int inputQ2A = Int32.Parse(Console.ReadLine());
                                switch (inputQ2A)
                                {
                                    case 1:
                                        {
                                            Console.WriteLine("What is the first integer?");
                                            int inputQ2A_1 = Int32.Parse(Console.ReadLine());
                                            Console.WriteLine("What is the second integer?");
                                            int inputQ2B_1 = Int32.Parse(Console.ReadLine());
                                            Console.WriteLine($"The sum of {inputQ2A_1} and {inputQ2B_1} is {Convert.ToString(Q2int.add(inputQ2A_1, inputQ2B_1))}.");
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.WriteLine("What is the first string?");
                                            string inputQ2A_1 = Console.ReadLine();
                                            Console.WriteLine("What is the second string?");
                                            string inputQ2B_1 = Console.ReadLine();
                                            Console.WriteLine($"The concatenation of \"{inputQ2A_1}\" and \"{inputQ2B_1}\" is {Q2string.add(inputQ2A_1, inputQ2B_1)}.");
                                            break;
                                        }
                                    case 3:
                                        {
                                            Q2list.add(Q2list.var1, Q2list.var2);
                                            Console.ReadLine();
                                            break;
                                        }
                                    case 4:
                                        {
                                            Q2bool = false;
                                            break;
                                        }
                                }
                            }
                            break;
                        }



                    case 3:
                        {
                            Console.WriteLine("Question 3 Weekly Test 4");
                            Question3Classes<int, int, string> Q3A = new Question3Classes<int, int, string>();
                            Question3Classes<bool, string, double> Q3B = new Question3Classes<bool, string, double>();
                            Q3A.inspectMethod(2, 5);
                            Q3A.validateMethod(3);
                            Q3B.inspectMethod(true, "false");
                            Q3B.validateMethod(false);
                            Console.ReadLine();

                            break;
                        }

                    case 4:
                        {
                            Calculator Q4Calculator = new Calculator();
                            Thread Q4Thread = new Thread(Q4Calculator.seperateThread);
                            try
                            {
                                Q4Thread.Start();
                            }
                            catch(Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                Console.WriteLine(ex.StackTrace);
                            }

                            Console.ReadLine();
                            break;
                        }

                    case 5:
                        {
                            w = false;
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Invalid input, please try again.");
                            break;
                        }
                }
            }
        }
    }
}
