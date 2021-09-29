using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Toh Wei Ming                Weekly Test 2");
            bool w = true;
            while(w == true)
            {
                Console.WriteLine("\nPlease key the question number(1 to 4) for which you would like to view or alternatively, 5 to end the program.");
                int input = Int32.Parse(Console.ReadLine());
                switch (input)
                {
                    
                    
                    
                    case 1:
                        {
                            LandCalculator LC = new LandCalculator();
                            Console.WriteLine("Cost per sq. foot?");
                            LC.cost = double.Parse(Console.ReadLine());
                            bool Q1 = true;

                            while(Q1 == true)
                            {
                                Console.WriteLine("\nTo continue, type y.\nTo go back to question selection, type q.");
                                string q1 = Console.ReadLine();
                                switch(q1)
                                {
                                    case "y":
                                        {
                                            Console.WriteLine("Input length of rectangle in ft.");
                                            LC.length = double.Parse(Console.ReadLine());
                                            Console.WriteLine("Input breath of rectangle in ft.");
                                            LC.breath = double.Parse(Console.ReadLine());
                                            Console.WriteLine($"Total cost of rectangle of Length {LC.length} and Breath {LC.breath} is: {LC.finalCost()}\n");
                                            break;
                                        }
                                    case "q":
                                        {
                                            Q1 = false;
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("Incorrect input, please key in either q or y.");
                                            break;
                                        }
                                }
                            }
                            break;
                        }
                    
                    
                    
                    case 2:
                        {
                            Line line = new Line();
                            bool Q2 = true;

                            while (Q2 == true)
                            {
                                Console.WriteLine("\nTo continue, type y.\nTo go back to question selection, type q.");
                                string q2 = Console.ReadLine();
                                switch (q2)
                                {
                                    case "y":
                                        {
                                            Console.WriteLine("\nx value of starting point: ");
                                            line.x1 = Int32.Parse(Console.ReadLine());
                                            Console.WriteLine("\ny value of starting point: ");
                                            line.y1 = Int32.Parse(Console.ReadLine());
                                            Console.WriteLine("\nx value of ending point: ");
                                            line.x2 = Int32.Parse(Console.ReadLine());
                                            Console.WriteLine("\ny value of ending point: ");
                                            line.y2 = Int32.Parse(Console.ReadLine());
                                            line.display();
                                            Console.WriteLine($"The slope of a line with starting point {line.x1},{line.y1} and {line.x2},{line.y2} is {line.slope()}.");
                                            break;
                                        }
                                    case "q":
                                        {
                                            Q2 = false;
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("Incorrect input, please key in either q or y.");
                                            break;
                                        }
                                }
                            }
                            break;
                        }
                    
                    
                    
                    case 3:
                        {
                            Firstclass fc = new Firstclass();
                            Secondclass sc = new Secondclass();
                            Thirdclass tc = new Thirdclass();
                            bool Q3 = true;

                            while (Q3 == true)
                            {
                                Console.WriteLine("\nTo continue, type y.\nTo go back to question selection, type q.");
                                string q3 = Console.ReadLine();
                                switch (q3)
                                {
                                    case "y":
                                        {
                                            Console.WriteLine("Enter distance of travel");
                                            double q3input = Convert.ToDouble(Console.ReadLine());
                                            Console.WriteLine("Which class of travel will you be flying? (First/Second/Third)");
                                            string q3input2 = Console.ReadLine();
                                            bool q3bool = true;
                                            while (q3bool == true)
                                            {
                                                switch (q3input2)
                                                {
                                                    case "First":
                                                        {
                                                            Console.WriteLine($"The total cost of your journey of distance {q3input} flying First Class is {fc.totalcost(q3input)}.");
                                                            q3bool = false;
                                                            break;
                                                        }
                                                    case "Second":
                                                        {
                                                            Console.WriteLine($"The total cost of your journey of distance {q3input} flying Second Class is {sc.totalcost(q3input)}.");
                                                            q3bool = false;
                                                            break;
                                                        }
                                                    case "Third":
                                                        {
                                                            Console.WriteLine($"The total cost of your journey of distance {q3input} flying Third Class is {tc.totalcost(q3input)}.");
                                                            q3bool = false;
                                                            break;
                                                        }
                                                    default:
                                                        {
                                                            Console.WriteLine("Invalid input, please try again.");
                                                            break;
                                                        }
                                                }
                                            }
                                            break;
                                        }
                                    case "q":
                                        {
                                            Q3 = false;
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("Incorrect input, please key in either q or y.");
                                            break;
                                        }
                                }
                            }
                            break;
                        }
                   
                    case 4:
                        {
                            //doing classes. 
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
