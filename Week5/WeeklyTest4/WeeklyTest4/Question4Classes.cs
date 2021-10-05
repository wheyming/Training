using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyTest4
{
    class CustomException : Exception
    {

    }

    class Calculator
    {
        public void seperateThread()
        {
            Console.WriteLine("Would you like to:\n1.) Add?\n2.) Subtract?\n3.) Multiply?\n4.) Divide?\n5.) Find Remainder?\n6.) Find Power of?\n7.) End\nInput the integer of the operation.");
            int inputQ4 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is the first number?");
            int inputQ4A_1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is the second number?");
            int inputQ4B_1 = Int32.Parse(Console.ReadLine());
            switch (inputQ4)
            {
                case 1:
                    {
                        Add(inputQ4A_1, inputQ4B_1);
                        break;
                    }
                case 2:
                    {
                        Subtract(inputQ4A_1, inputQ4B_1);
                        break;
                    }
                case 3:
                    {
                        Multiply(inputQ4A_1, inputQ4B_1);
                        break;
                    }
                case 4:
                    {
                        Divide(inputQ4A_1, inputQ4B_1);
                        break;
                    }
                case 5:
                    {
                        Remainder(inputQ4A_1, inputQ4B_1);
                        break;
                    }
                case 6:
                    {
                        Powerof(inputQ4A_1, inputQ4B_1);
                        break;
                    }
                default:
                    {
                        throw new CustomException();
                    }
            }

        }

        void Add(double A, double B)
        {
            try
            {
                Console.WriteLine(A + B);
            }
            catch
            {

            }
        }

        void Divide(double A, double B)
        {
            try
            {
                Console.WriteLine(A / B);
            }
            catch
            {

            }
        }

        void Multiply(double A, double B)
        {
            try
            {
                Console.WriteLine(A * B);
            }
            catch
            {

            }
        }

        void Subtract(double A, double B)
        {
            try
            {
                Console.WriteLine(A - B);
            }
            catch
            {

            }
        }

        void Remainder(double A, double B)
        {
            try
            {
                Console.WriteLine(A % B);
            }
            catch
            {

            }
        }
        void Powerof(double A, double B)
        {
            try
            {
                Console.WriteLine(Math.Pow(A, B));
            }
            catch
            {

            }
        }
    }
}
