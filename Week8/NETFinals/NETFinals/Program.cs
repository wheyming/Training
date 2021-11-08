using System;
using System.Collections.Generic;

namespace NETFinals
{
    class Program
    {
        static void Main(string[] args)
        {
            //FinalsQuestion1 FQ1 = new FinalsQuestion1();

            //Console.WriteLine("Enter integer to find prime numbers till that number.");
            //try
            //{
            //    int input1_1 = Convert.ToInt32(Console.ReadLine());
            //    if (input1_1 < 0)
            //    {
            //        throw new NegativeNumberException();
            //    }
            //    foreach (int primeNumber in FQ1.GetAllPrimeNumbers(input1_1))
            //    {
            //        Console.Write(primeNumber + " ");
            //    }
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Invalid input.");
            //}

            //try
            //{
            //    Console.WriteLine("\n");
            //    Console.WriteLine("Enter integer to find factorial");
            //    int input1_2 = Convert.ToInt32(Console.ReadLine());
            //    if (input1_2 < 0)
            //    {
            //        throw new NegativeNumberException();
            //    }
            //    Console.WriteLine(FQ1.FindFactorial(input1_2));
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Invalid input.");
            //}

            FinalsQuestion3 FQ3 = new FinalsQuestion3();
            try
            {
                Console.WriteLine("Enter string to turn into camel casing.");
                string input3_1 = Console.ReadLine();
                if (Equals(input3_1, ""))
                {
                    throw new Exception();
                }
                Console.WriteLine(FQ3.StringToCamelCasing(input3_1));
            }
            catch(Exception)
            {
                Console.WriteLine("Invalid input.");
            }

            try
            {
                Console.WriteLine("Enter string to calculate vowels and consonant.");
                string input3_2 = Console.ReadLine();
                if (Equals(input3_2, ""))
                {
                    throw new Exception();
                }
                foreach (KeyValuePair<char, int> kvpResult in FQ3.ShowVowelsAndConsonantsInString(input3_2))
                {
                    Console.WriteLine(kvpResult);
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Invalid input.");
            }

            Console.ReadLine();
        }
    }
}
