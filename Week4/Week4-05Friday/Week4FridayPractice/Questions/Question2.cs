using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Questions
{
    class Question2
    {
        int Q2input;
        string[] Q2;

        public void getInput()
        {
            Console.Write("Enter the limit: ");
            Q2input = Convert.ToInt32(Console.ReadLine());
        }

        public void printnumbers()
        {
            Q2[0] = "0";
            for (int i = 1; i < Q2input + 1; i++)
            {
                Thread.Sleep(1000);
                for (int j = 1; j <= i; j++)
                {
                    if (i == 1)
                    {
                        Console.Write(Q2[1]);
                    }
                    else
                    {
                        Console.Write(Q2[j] + "\t");
                    }
                }
                Console.WriteLine("\n");
            }
        }

        public void addNumbers()
        {
            Q2 = new string[Q2input + 1];
            for (int i = 1; i < Q2input + 1; i++)
            {
                if (i == 1)
                {
                    Thread.Sleep(500);
                    Q2[1] = "1";
                }
                else
                {
                    Thread.Sleep(500);
                    Q2[i] = Convert.ToString(Convert.ToInt32(Q2[i - 1]) + Convert.ToInt32(Q2[i - 2]));
                }
            }

        }
    }
}
