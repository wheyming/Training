using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Questions
{
    class Question3
    {
        int Q3input;

        public void getQ3input()
        {
            Console.WriteLine("Enter Q3input: ");
            Q3input = Convert.ToInt32(Console.ReadLine());
        }

        public void printSpaces()
        {
            for (int j = Q3input; j >= 0; j--)
            {
                for (int k = j; k >= 0; k--)
                {
                    Console.Write(" ");
                }
                Thread.Sleep(1000);
            }
        }

        public void printAlphabet()
        {
            for (int l = 1; l <= Q3input; l++)
            {
                for (int i = Convert.ToInt32('A'); i < l + Convert.ToInt32('A'); i++)
                {
                    Console.Write((char)i);
                }
                for (int i = l + Convert.ToInt32('A') - 2; i > Convert.ToInt32('A') - 1; i--)
                {
                    Console.Write((char)i);
                }
                Console.WriteLine("\n");
                Thread.Sleep(1000);
            }
        }
    }
}
