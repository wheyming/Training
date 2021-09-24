using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrimeNumber
{
    class ReversePNumProgram
    {
        public bool testForPrime(int a)
        {
            bool test = true;
            while (test == true)
            {
                for (int j = 2; j < a; j++)
                {
                    if (a % j == 0)
                    {
                        test = false;
                        break;
                    }
                }
                break;
            }
            return test;
        }

        public int ReverseNum(int b)
        {
            int res = 0;
            while (b > 0)
            {
                res = res * 10 + b % 10;
                b = b / 10;
            }
            return res;
        }

        static void Main(string[] args)
        {
            int[] Numarr = new int[100];
            ReversePNumProgram P = new ReversePNumProgram();
            int Rnum;
            int Rarr = 0;
            for (int i = 1; i < 101; i++)
            {
                bool Y = P.testForPrime(i);

                if ( Y == true)
                {
                    Rnum = P.ReverseNum(i);
                    if ( P.testForPrime(Rnum) == true )
                    {
                        Numarr[Rarr] = Rnum;
                        Rarr += 1;
                    }
                }
            }

            foreach(int num in Numarr)
            {
                if (num != 0)
                {
                    Console.WriteLine(num);
                }
            }
            Console.ReadLine();
        }
    }
}
