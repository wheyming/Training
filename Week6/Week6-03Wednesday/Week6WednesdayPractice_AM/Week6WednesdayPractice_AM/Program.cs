using System;
using System.Collections.Generic;
using System.IO;

namespace Week6WednesdayPractice_AM
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input ip address string.");
            string input = Console.ReadLine();
            checkipAddress(input);

            //calculateOccurance();
            //checkStringHalf();
        }

        private static void checkStringHalf()
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            Dictionary<char, int> dict2 = new Dictionary<char, int>();
            bool evencheck;
            string input;
            do
            {
                evencheck = true;
                Console.WriteLine("Input string");
                input = Console.ReadLine();
                if (input.Length % 2 != 0)
                {
                    evencheck = false;
                    Console.WriteLine("Please input string with even length.");
                }
            } while (evencheck == false);
            string substring1 = input.Substring(0, (input.Length / 2) - 1);
            string substring2 = input.Substring(input.Length / 2);
            foreach(char d in substring1)
            {
                char c = char.ToUpper(d);
                if(c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                {
                    if (dict.ContainsKey(c))
                    {
                        dict[c]++;
                    }
                    else
                    {
                        dict.Add(c, 1);
                    }
                }
            }
            foreach (char d in substring2)
            {
                char c = char.ToUpper(d);
                if (c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                {
                    if (dict2.ContainsKey(c))
                    {
                        dict2[c]++;
                    }
                    else
                    {
                        dict2.Add(c, 1);
                    }
                }
            }
            bool vowelcheck = true;
            foreach(char i in dict.Keys)
            {
                if (dict2.ContainsKey(i))
                {
                    if (dict[i] != dict2[i])
                    {
                        vowelcheck = false;
                        break;
                    }
                }
            }
            if (vowelcheck == true)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            Console.ReadLine();
        }

        public static bool checkipAddress(string input1)
        {           
            string[] strarr = input1.Split('.');
            bool checka = true;
            bool checkb = true;
            bool checkc = true;
            foreach (string splitstring in strarr)
            {
                if (Int32.TryParse(splitstring, out int result) == false)
                {
                    checka = false;
                    break;
                }
                if (Convert.ToInt32(splitstring) < 0 || Convert.ToInt32(splitstring) > 255)
                {
                    checkb = false;
                    break;
                }
            }
            if (strarr.Length != 4)
            {
                checkc = false;
            }
            if (checka == true && checkb == true && checkc == true)
            {
                Console.WriteLine("The ip address is valid.");
                return true;
            }
            else
            {
                Console.WriteLine("The ip address is invalid.");
                return false;
            }
        }

        private static void calculateOccurance()
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();

            Console.WriteLine("What is the name of the file you woule like to read?");
            string input1 = Console.ReadLine();
            FileStream practice1 = new FileStream(input1 + ".txt", FileMode.Open, FileAccess.Read);
            StreamReader practice1read = new StreamReader(practice1);
            practice1read.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = practice1read.ReadToEnd();
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetterOrDigit(str[i]) == true)
                {
                    if (dict.ContainsKey(str[i]))
                    {
                        dict[str[i]]++;
                    }
                    else
                    {
                        dict.Add(str[i], 1);
                    }
                }
            }
            practice1read.Close();
            practice1.Close();

            Console.WriteLine("What is the name of the file you woule like to write?");
            string input2 = Console.ReadLine();
            FileStream practice2 = new FileStream(input2 + ".txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter practice2write = new StreamWriter(practice2);
            foreach (KeyValuePair<char, int> combo in dict)
            {
                practice2write.WriteLine(combo);
            }
            practice2write.Flush();
            practice2write.Close();
            practice2.Close();
        }
    }
}
