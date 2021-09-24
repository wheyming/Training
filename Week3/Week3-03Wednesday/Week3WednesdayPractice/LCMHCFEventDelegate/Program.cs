using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCMHCFEventDelegate
{
    delegate int HCFCalculate(int x, int y);
    delegate int LCMCalculate(int x, int y);
    

    class Program
    {
        event EventHandler HCFcomputed;

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

        }
    }
}
