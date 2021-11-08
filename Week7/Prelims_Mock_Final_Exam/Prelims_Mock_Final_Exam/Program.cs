using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prelims_Mock_Final_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> temp = new List<double>();
            Console.WriteLine(temp[0]);
            bool Q1Bool;
            do
            {
                try
                {
                    Q1Bool = true;
                    Console.WriteLine("Input first number");
                    int input1_1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Input second number");
                    int input1_2 = Convert.ToInt32(Console.ReadLine());
                    Question1Class Q1C = new Question1Class();
                    int LCM = Q1C.calculateLCM(input1_1, input1_2);
                    int HCF = Q1C.calculateHCF(input1_1, input1_2, LCM);
                    Console.WriteLine($"The LCM of {input1_1} and {input1_2} is {LCM}.");
                    Console.WriteLine($"The HCF of {input1_1} and {input1_2} is {HCF}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input.");
                    Q1Bool = false;
                }
            } while (Q1Bool == false);


            bool Q3Bool;
            do
            {
                try
                {
                    
                    Q3Bool = true;
                    Question3Class Q3C = new Question3Class();
                    Console.WriteLine("Input string");
                    string input3_1 = Console.ReadLine();
                    if (input3_1.Length == 0)
                    {
                        throw new NoInputException();
                    }
                    Console.WriteLine(Q3C.removeDuplicate(input3_1));
                }
                catch (NoInputException)
                {
                    Console.WriteLine("Invalid input.");
                    Q3Bool = false;
                }

            } while (Q3Bool == false);
            Console.ReadLine();
        }
    }
}
