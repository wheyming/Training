using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5MondayPractice
{
    public delegate void CalculateAngles();
    public class InvalidNumberException : Exception
    {
        public InvalidNumberException()
        {
            Console.WriteLine("Invalid Input, please input at least 3 angles and maximum 5 angles.");
        }
    }
    class Question1Classes
    {
        public event CalculateAngles CalculateAnglesEvent;
        public void checkAngles()
        {
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
                            CalculateAnglesEvent += Question1Classes_CalculateAnglesEventTriangle;
                            if (CalculateAnglesEvent != null)
                            {
                                CalculateAnglesEvent.Invoke();
                            }
                            CalculateAnglesEvent -= Question1Classes_CalculateAnglesEventTriangle;
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
                            CalculateAnglesEvent += Question1Classes_CalculateAnglesEventQuadrilaterial;
                            if (CalculateAnglesEvent != null)
                            {
                                CalculateAnglesEvent.Invoke();
                            }
                            CalculateAnglesEvent -= Question1Classes_CalculateAnglesEventQuadrilaterial;
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
                            CalculateAnglesEvent += Question1Classes_CalculateAnglesEventPentagon;
                            if (CalculateAnglesEvent != null)
                            {
                                CalculateAnglesEvent.Invoke();
                            }
                            CalculateAnglesEvent -= Question1Classes_CalculateAnglesEventTriangle;
                        }
                        else
                        {
                            Console.WriteLine("No, a geometrical shape cannot be formed.");
                        }
                        break;
                    }
                default:
                    {
                        throw new InvalidNumberException();
                    }
            }
        }

        public void Question1Classes_CalculateAnglesEventTriangle()
        {
            Console.WriteLine("Yes, a triangle can be formed.");
        }

        public void Question1Classes_CalculateAnglesEventQuadrilaterial()
        {
            Console.WriteLine("Yes, a quadrilaterial can be formed.");
        }

        public void Question1Classes_CalculateAnglesEventPentagon()
        {
            Console.WriteLine("Yes, a pentagon can be formed.");
        }
    }
}
