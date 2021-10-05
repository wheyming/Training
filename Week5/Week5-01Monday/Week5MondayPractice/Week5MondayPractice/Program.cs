using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5MondayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Question1Classes Q1 = new Question1Classes();
            CalculateAngles calcAngles = delegate
            {
                Console.WriteLine("Q1: Please input the angle values. (Seperate angles by a space or comma)");
            };
            calcAngles += Q1.checkAngles;
            try
            {
                calcAngles();
            }
            catch (InvalidNumberException ex)
            {
            }
            Console.ReadLine();
        }
    }
}
