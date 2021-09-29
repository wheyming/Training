using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WeeklyTest3
{
    class Program
    {
        static public bool isCounterRunning { get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Toh Wei Ming                Weekly Test 2");
            bool w = true;
            while (w == true)
            {
                Console.WriteLine("\nPlease key the number(1 to 4) for which you would like to view or alternatively, 5 to end the program.");
                int input = Int32.Parse(Console.ReadLine());
                switch (input)
                {


                    case 1:
                        {
                            Console.WriteLine("Question 1 Weekly Test 3.");
                            LotteryManager Q1LotteryManager = new LotteryManager();
                            getLotteryNumdel Numberdel = new getLotteryNumdel(Q1LotteryManager.buyLottery);
                            selectWinnerdel Winnerdel = new selectWinnerdel(Q1LotteryManager.selectWinner);
                            Q1LotteryManager.getLotteryNumEvent += Q1LotteryManager_getLotteryNumEvent;
                            Q1LotteryManager.selectWinnerEvent += Q1LotteryManager_selectWinnerEvent;
                           
                            Numberdel();
                            Winnerdel();
                            Console.ReadLine();
                            break;
                        }



                    case 2:
                        {
                            bool y = true;
                            Console.WriteLine("Question 3 Weekly Test 3.");
                            Timer timer = new Timer();
                            timer.stopEvent += Timer_stopEvent;
                            timer.startEvent += timer.Timer_startEvent;

                            timer.start();
                            Thread.Sleep(500);
                            do
                            {
                                Console.WriteLine("Key in 'Y' to stop");
                                Char Y = Char.ToUpper((Char.Parse(Console.ReadLine())));
                                if (Y == 'Y')
                                {
                                    timer.stop();
                                    y = false;
                                }
                            } while (y == true);
                            Console.ReadLine();
                            break;
                        }



                    case 3:
                        {
                            Console.WriteLine("Question 4 Weekly Test 3");

                            break;
                        }

                    case 4:
                        {
                            Question6Classes Q6 = new Question6Classes();
                            
                            Console.WriteLine("Question 6 Weekly Test 3");
                            Console.WriteLine("Input index to be found.");
                            int Q6a = Int32.Parse(Console.ReadLine());
                            Q6.getElement(Q6a);
                            
                            Console.WriteLine("\n\nInput first number.");
                            int Q6b = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Input second number.");
                            int Q6c = Int32.Parse(Console.ReadLine());
                            Q6.division(Q6b, Q6c);
                            
                            Console.WriteLine("\n\nInput string.");
                            string Q6d = Console.ReadLine();
                            Console.WriteLine("Input index.");
                            int Q6e = Int32.Parse(Console.ReadLine());
                            Q6.calculate(Q6d, Q6e);
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

        private static void Timer_stopEvent()
        {
            isCounterRunning = false;
        }

        private static void Q1LotteryManager_getLotteryNumEvent()
        {
            Random rand = new Random();
            bool w = true;
            for (int q1i = 0; q1i < 5; q1i++)
            {
                Console.WriteLine("Please enter name");
                LotteryManager.lotteryName[q1i] = Console.ReadLine();

                do
                {
                    for (int q1j = 0; q1j < 12; q1j++)
                    {
                        LotteryManager.lotteryNumbers[q1i] = LotteryManager.lotteryNumbers[q1i] + Convert.ToString(rand.Next(0, 9));
                    }
                    w = true;
                    for (int q1k = 0; q1k < q1i; q1k++)
                    {
                        if (Equals(LotteryManager.lotteryNumbers[q1i], LotteryManager.lotteryNumbers[q1k]))
                        {
                            w = false;
                        }
                    }
                } while (w == false);
                
            }
        }

        private static void Q1LotteryManager_selectWinnerEvent()
        {
            Random rand = new Random();
            int WinnerIndex = rand.Next(0, 4);
            Console.WriteLine($"The winner of the lottery is {LotteryManager.lotteryName[WinnerIndex]}, and the winning number is {LotteryManager.lotteryNumbers[WinnerIndex]}.");
        }
    }
}
