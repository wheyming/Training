using System;
using System.Collections.Generic;
using System.Numerics;

namespace NETFinals
{
    class NegativeNumberException : Exception
    { }

    class FinalsQuestion1
    {
        public List<int> GetAllPrimeNumbers(int input)
        {
            List<int> primeNumbersArr = new List<int>();
            bool isPrime;

            for (int Q1a = 2; Q1a < input; Q1a++)
            {
                isPrime = true;
                for (int Q1a_a = 2; Q1a_a < (Q1a / 2); Q1a_a++)
                {
                    if (Q1a % Q1a_a == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primeNumbersArr.Add(Q1a);
                }
            }
            return primeNumbersArr;
        }

        public BigInteger FindFactorial(int input)
        {
            BigInteger factorialResult = input;
            for (int Q1b = input - 1; Q1b > 0; Q1b--)
            {
                factorialResult *= Q1b;
            }
            return factorialResult;
        }
    }
}
