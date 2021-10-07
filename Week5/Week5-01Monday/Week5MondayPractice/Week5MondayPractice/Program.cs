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
            //Question1Classes Q1 = new Question1Classes();
            //CalculateAngles calcAngles = delegate
            //{
            //    Console.WriteLine("Q1: Please input the angle values. (Seperate angles by a space or comma)");
            //};
            //calcAngles += Q1.checkAngles;
            //try
            //{
            //    calcAngles();
            //}
            //catch (InvalidNumberException ex)
            //{
            //}
            //Console.ReadLine();

            Question3Classes Q3 = new Question3Classes();
            bool Q3test;
            Q3.passwordEvent += Q3.PasswordAccepted;

            do
            {
                Console.WriteLine("Input your password");
                string password = Console.ReadLine();
                Q3test = true;
                try
                {
                    Q3.PasswordValidationUpper(password);
                }
                catch (UppercaseException ex)
                {
                    Q3test = false;
                }
                try
                {
                    Q3.PasswordValidationLower(password);
                }
                catch (LowercaseException ex)
                {
                    Q3test = false;
                }
                try
                {
                    Q3.PasswordValidationDigit(password);
                }
                catch (DigitException ex)
                {
                    Q3test = false;
                }
                try
                {
                    Q3.PasswordValidationNumber(password);
                }
                catch (NumberofCharException ex)
                {
                    Q3test = false;
                }
                try
                {
                    Q3.PasswordValidationSpecialChar(password);
                }
                catch (SpecialCharException ex)
                {
                    Q3test = false;
                }
                try
                {
                    Q3.PasswordValidationRepeatedTwo(password);
                }
                catch (RepeatedTwoException ex)
                {
                    Q3test = false;
                }
                if (Q3test == true)
                {
                    Q3.Question3app(password);
                }
            } while (Q3test == false);
            Console.ReadLine();
        }
    }
}
