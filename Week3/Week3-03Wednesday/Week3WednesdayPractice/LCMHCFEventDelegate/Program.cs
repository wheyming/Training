using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCMHCFEventDelegate
{
    delegate int HCFCalculatedel(int x, int y, int z);
    delegate int LCMCalculatedel(int x, int y);

    class Calculate
    {
        public event HCFCalculatedel HCFEvent;
        public event LCMCalculatedel LCMEvent;

        int[] inputAarr;
        int[] inputBarr;
        int LCM;
        bool w;
        public int calculateHCF(int a, int b, int LCMcal)
        {      
            if (HCFEvent != null)
            {
                HCFEvent.Invoke(a, b, LCMcal);
            }            
            return ((a * b) / LCMcal);
        }

        public int calculateLCM(int a, int b)
        {
            inputAarr = new int[100];
            inputBarr = new int[100];
            LCM = 0;
            w = true;
            while (w == true)
            {
                for (int i = 1; i < 100; i++)
                {
                    inputAarr[i - 1] = (a * i);
                    inputBarr[i - 1] = (b * i);

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
            if (LCMEvent != null)
            {
                LCMEvent.Invoke(a, b);
            }
            return LCM;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Q1: Please input first number.");
            int inputA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Q2: Please input second number.");
            int inputB = Convert.ToInt32(Console.ReadLine());
            Calculate cal = new Calculate();
            LCMCalculatedel LCMdel = new LCMCalculatedel(cal.calculateLCM);
            HCFCalculatedel HCFdel = new HCFCalculatedel(cal.calculateHCF);
            cal.HCFEvent += Cal_HCFEvent;
            cal.LCMEvent += Cal_LCMEvent;

            int LCMcal = LCMdel(inputA, inputB);
            Console.WriteLine($"The LCM of {inputA} and {inputB} is {LCMcal}.");
            int HCF = HCFdel(inputA, inputB, LCMcal);
            Console.WriteLine($"The HCF of {inputA} and {inputB} is {HCF}.");
            Console.ReadLine();
        }

        private static int Cal_LCMEvent(int x, int y)
        {
            Console.WriteLine("LCM calculation completed.");
            return 0;
        }

        private static int Cal_HCFEvent(int x, int y, int z)
        {
            Console.WriteLine("HCF calculation completed.");
            return 0;
        }
    }
}
