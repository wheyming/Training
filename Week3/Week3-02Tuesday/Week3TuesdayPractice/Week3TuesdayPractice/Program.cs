using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3TuesdayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Q1: Please input first number.");
            int inputA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Q2: Please input second number.");
            int inputB = Convert.ToInt32(Console.ReadLine());
            int[] inputAarr = new int[100];
            int[] inputBarr = new int[100];
            int LCM = 0;
            bool w = true;
            while (w == true)
            {
                for (int i = 1; i < 100; i++)
                {
                    inputAarr[i - 1] = (inputA * i);
                    inputBarr[i - 1] = (inputB * i);

                    for (int k = 0; k < i; k++)
                    {
                        if (inputAarr[i - 1] == inputBarr[k])
                        {
                            LCM = inputAarr[i - 1];
                            w = false;
                            break;
                        }
                        if (inputBarr[i - 1] == inputAarr[k])
                        {
                            LCM = inputBarr[i - 1];
                            w = false;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    if (w == false)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine($"The LCM of {inputA} and {inputB} is {LCM}.");
            int HCF = ((inputA * inputB) / LCM);
            Console.WriteLine($"The HCF of {inputA} and {inputB} is {HCF}.");



            Console.WriteLine("\n\nQ2: Please input your sentence.");
            string input2 = Console.ReadLine();
            string[] input2arr = input2.Split(' ');
            Console.WriteLine("Number of words: " + input2arr.Length);
            foreach (string q2 in input2arr)
            {
                Console.Write(q2 + ", ");
            }

            Console.WriteLine("\n\nQ3: Please input your line.");
            string input3 = Console.ReadLine();
            Console.WriteLine("Please input the word you would like to find.");
            string input32 = Console.ReadLine();
            if (input3.Contains(input32))
            {
                string[] input3arrs = input3.Split(' ');
                int count3 = 0;
                foreach (string input3arr in input3arrs)
                {
                    if (input3arr == input32)
                    {
                        count3++;
                    }
                }
                Console.WriteLine($"{input32} occurs {count3} times");

            }
            else
            {
                Console.WriteLine($"{input32} occurs 0 times");
            }

            Console.WriteLine("\n\nQ4: Please input the angle values. (Seperate angles by a space or comma)");
            string input4 = Console.ReadLine();
            string[] input4arr = input4.Split(' ', ',');
            int count4 = 0;
            int totalang = 0;
            foreach (string q4str in input4arr)
            {
                count4++;
            }
            switch (count4)
            {
                case 3:
                    {
                        foreach (string q4str in input4arr)
                        {
                            totalang += Convert.ToInt32(q4str);
                        }
                        if (totalang == 180)
                        {
                            Console.WriteLine("Yes, a Triangle can be formed.");
                        }
                        else
                        {
                            Console.WriteLine("No, a geometrical shape cannot be formed.");
                        }
                        break;
                    }
                case 4:
                    {
                        foreach (string q4str in input4arr)
                        {
                            totalang += Convert.ToInt32(q4str);
                        }
                        if (totalang == 360)
                        {
                            Console.WriteLine("Yes, a quadrilaterial can be formed.");
                        }
                        else
                        {
                            Console.WriteLine("No, a geometrical shape cannot be formed.");
                        }
                        break;
                    }
                case 5:
                    {
                        foreach (string q4str in input4arr)
                        {
                            totalang += Convert.ToInt32(q4str);
                        }
                        if (totalang == 540)
                        {
                            Console.WriteLine("Yes, a Pentagon can be formed.");
                        }
                        else
                        {
                            Console.WriteLine("No, a geometrical shape cannot be formed.");
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid input.");
                        break;
                    }
            }

            Console.WriteLine("\n\nQ5: Please input string.");
            string input5 = Console.ReadLine();
            string VA = "";
            foreach (char q5 in (input5))
            {
                int q5x = q5;
                q5x++;
                VA = VA + Convert.ToChar(q5x);
            }
            Console.WriteLine(VA);



            Console.ReadLine();
        }
    }
}
