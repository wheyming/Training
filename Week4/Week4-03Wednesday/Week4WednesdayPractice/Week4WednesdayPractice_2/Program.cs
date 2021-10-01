using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4WednesdayPractice_2
{
    class Question1Classes
    {
        public int Q1input()
        {
            int a = 500 * 500;
            return a;
        }

        public string Q1_2input()
        {
            return "H";
        }

        public void Q1input_2(object a)
        {
            Console.WriteLine(a);
        }
    }

    class Question2Classes
    {
        public string[] Q2arr = new string[] { "Poo", "Poo Poo", "Potato", "Parrot", "Papaya" };

    }

    class Question3Classes
    {
        public class MyArgumentException : Exception
        {
            public MyArgumentException()
            {

            }
            public MyArgumentException(int a, int b) : base(String.Format("Integer {0} and {1} are equal.", a, b))
            {
            
            }
        }

        public void checkingQ3()
        {
            Console.WriteLine("Enter integer a");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter integer b");
            int b = Int32.Parse(Console.ReadLine());

            try
            {
                checkEqual(a, b);
            }
            catch (MyArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void checkEqual(int a, int b)
        {
            if (a == b)
            {
                throw new MyArgumentException(a, b);
            }
        }
    }

    class Question4Classes
    {
        class Q4EventArgs : EventArgs
        {
            public Q4EventArgs()
            {

            }

            
        }

        class Q4publisher
        {

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Question1Classes Q1 = new Question1Classes();
            Q1.Q1input_2(Q1.Q1input());
            Q1.Q1input_2(Q1.Q1_2input());
            Console.ReadLine();



            Question2Classes Q2 = new Question2Classes();
            Predicate<string> Q2predicate = a =>
            {
                bool w = false;
                foreach (string str in Q2.Q2arr)
                {
                    if (str == a)
                    {
                        w = true;
                        break;
                    }
                }
                return w;
            };
            Console.WriteLine(Q2predicate("Papaya"));
            Console.ReadLine();



            Question3Classes Q3 = new Question3Classes();
            Q3.checkingQ3();
            Console.ReadLine();




        }
    }
}
