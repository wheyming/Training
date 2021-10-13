using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> PrimeList = new List<int>();
            bool prime;
            string inputQ4;
            
            for (; ; )
            {
                int inputQ4Dec = 0;
                prime = true;
                Console.WriteLine("Enter Hexadecimal number.");
                inputQ4 = Console.ReadLine();
                for (int i = 0; i < inputQ4.Length; i++)
                {
                    if (char.IsNumber(inputQ4[inputQ4.Length - i - 1]) == true)
                    {
                        inputQ4Dec += ((inputQ4[inputQ4.Length - i - 1] - 48) * Convert.ToInt32(Math.Pow(16, i))); // Ascii value of char 1 and int 1 is different.
                    }
                    else if ((char.ToUpper(inputQ4[inputQ4.Length - i - 1])) == 'A' || (char.ToUpper(inputQ4[inputQ4.Length - i - 1])) == 'B' || (char.ToUpper(inputQ4[inputQ4.Length - i - 1])) == 'C' || (char.ToUpper(inputQ4[inputQ4.Length - i - 1])) == 'D' || (char.ToUpper(inputQ4[inputQ4.Length - i - 1])) == 'E' || (char.ToUpper(inputQ4[inputQ4.Length - i - 1])) == 'F')
                    {
                        inputQ4Dec += ((inputQ4[inputQ4.Length - i - 1] - 55) * Convert.ToInt32(Math.Pow(16, i)));
                    }
                }
                for (int j = 2; j < inputQ4Dec; j++)
                {
                    if (inputQ4Dec % j == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime == true)
                {
                    PrimeList.Add(inputQ4Dec);
                }
                Console.Write("List of prime numbers: ");
                int count = PrimeList.Count();
                foreach (int k in PrimeList)
                {
                    if (count == 1)
                    {
                        Console.Write($"{k}\n");
                    }
                    else
                    {
                        Console.Write($"{k}, ");
                        count--;
                    }
                }
            }
        }
    }
}
