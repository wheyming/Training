using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6ThursdayPracticeDemo_AM
{
    class Program
    {
        static void Main(string[] args)
        {
            //returnTarget();
            //reverseNumber();
            //reverseWords();
            validationCorrect();
            Console.ReadLine();
        }

        private static void returnTarget()
        {
            Console.WriteLine("Please input array of integers");
            string input = Console.ReadLine();
            Console.WriteLine("Please input target");
            int target = Convert.ToInt32(Console.ReadLine());
            string[] arr = input.Split(' ', ',');
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i; j < arr.Length; j++)
                {
                    if(Convert.ToInt32(arr[i]) + Convert.ToInt32(arr[j]) == target)
                    {
                        Console.WriteLine($"{arr[i]} + {arr[j]} = {target} ");
                        Console.WriteLine($"[{i}],[{j}]");
                        break;
                    }
                }    
            }            
        }

        private static void reverseNumber()
        {
            int reversed = 0;
            int numbercount;
            Console.WriteLine("Enter number");
            int input = Convert.ToInt32(Console.ReadLine());
            numbercount = input;
            for(int i = 1; ; i++)
            {
                numbercount = numbercount / 10;
                if (numbercount == 0)
                {
                    numbercount = i;
                    break;                  
                }
            }
            for(int i = numbercount - 1; i >= 0; i--)
            {
                reversed += (input % 10) * Convert.ToInt32(Math.Pow(10, i));
                input = input / 10;
            }
            Console.WriteLine(reversed);
        }

        private static void reverseWords()
        {
            string substring;
            List<string> stringarr = new List<string>();
            List<int> lst = new List<int>();
            lst.Add(0);
            Console.WriteLine("Enter string");
            string input = Console.ReadLine();
            for(int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    lst.Add(i);
                }
            }
            for(int i = 1; i < lst.Count; i++)
            {
                substring = "";
                if (i == 1)
                {
                    for (int j = lst[i] - 1; j >= lst[i - 1]; j--)
                    {
                        substring += Convert.ToString(input[j]);
                    }
                    stringarr.Add(substring);
                }
                else
                {
                    for (int j = lst[i] - 1; j > lst[i - 1]; j--)
                    {
                        substring += Convert.ToString(input[j]);
                    }
                    stringarr.Add(substring);
                }
            }
            substring = "";
            for (int k = input.Length - 1; k > lst[lst.Count - 1]; k--)
            {
                substring += Convert.ToString(input[k]);
            }
            stringarr.Add(substring);
            foreach (string str in stringarr)
            {
                Console.Write(str + ' ');
            }
        }

        private static void validationCorrect()
        {
            bool check = true;
            bool startcheck = false;
            Stack<char> stck = new Stack<char>();
            Console.WriteLine("Enter string with only ‘(‘ , ‘)’ , ‘{‘ , ‘}’ , ‘[‘ , ‘]’ as character");
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                startcheck = true;
                if (input[i] == '(' || input[i] == '[' || input[i] == '{')
                {
                    stck.Push(input[i]);
                }
                else
                {
                    var temp = stck.Pop();
                    if (input[i] == ')' && temp == '(')
                    {
                        continue;
                    }
                    if (input[i] == '}' && temp == '{')
                    {
                        continue;
                    }
                    if (input[i] == ']' && temp == '[')
                    {
                        continue;
                    }
                    else
                    {
                        check = false;
                        break;
                    }
                }
            }
            if (startcheck == true && check == true && stck.Count == 0)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        private static void validationIncorrect()
        {
            Console.WriteLine("Enter string with only ‘(‘ , ‘)’ , ‘{‘ , ‘}’ , ‘[‘ , ‘]’ as character");
            string input = Console.ReadLine();
            bool validity = true;
            int doublecheck = 0;
            for(int i = 0; i < input.Length / 2; i++)
            {
                if(input[i] == '[')
                {
                    if (input[input.Length - 1 - i] != ']')
                    {
                        validity = false;
                        break;
                    }
                    else
                    {
                        doublecheck++;
                    }
                }
                if (input[i] == '(')
                {
                    if (input[input.Length - 1 - i] != ')')
                    {
                        validity = false;
                        break;
                    }
                    else
                    {
                        doublecheck++;
                    }
                }
                if (input[i] == '{')
                {
                    if (input[input.Length - 1 - i] != '}')
                    {
                        validity = false;
                        break;
                    }
                    else
                    {
                        doublecheck++;
                    }
                }
            }
            if (validity == true && doublecheck == input.Length / 2)
            { Console.WriteLine("Valid"); }    
            else
            { Console.WriteLine("Not valid"); }
        }

        private static void returnTargetMarvinAnswer()
        {
            int[] arr = new int[4] { 2, 7, 11, 15 };
            int target = 9;
            int length = arr.Length;
            int complement = 0;

            Dictionary<int, int> mydict = new Dictionary<int, int>();

            for(int i = 0; i < length; i++)
            {
                complement = target - arr[i];

                if (mydict.ContainsKey(arr[i]))
                {
                    Console.WriteLine(mydict[arr[i]]);
                    Console.WriteLine(i);
                }
                else
                {
                    mydict.Add(complement, i);
                }
                Console.ReadLine();
            }
        }
    }
}
