using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4ThursdayPractice_2
{
    class items<T>
    {
        public T[] itemarr;

        public T this[int index]
        {
            get { return itemarr[index]; }
            set { itemarr[index] = value; }
        }
    }



    class Methods
    {
        bool w;
        int same;
        string Q1input1;
        string Q1input2;


        public void callingMethod()
        {
            items<string> studentname = new items<string>();
            items<string> studentnumber = new items<string>();
            items<string> bookname = new items<string>();
            items<int> booknumber = new items<int>();
            studentname.itemarr = new string[5] { "A", "B", "C", "D", "E" };
            studentnumber.itemarr = new string[5] { "1110", "1111", "1112", "1113", "1114" };
            bookname.itemarr = new string[8] { "AAAAAAAA", "AAAAAB", "AHASJHA", "AAAAASAA", "AAASA", "AAEAA", "AESA", "AASJJA" };
            booknumber.itemarr = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };


            do
            {
                w = true;
                try
                {
                    Console.WriteLine("Please enter student name");
                    Q1input1 = Console.ReadLine();
                    Console.WriteLine("Please enter student number");
                    Q1input2 = Console.ReadLine();
                    for (int i = 0; i < 5; i++)
                    {
                        if ((Q1input1 == studentname.itemarr[i]) && (Q1input2 == studentnumber.itemarr[i]))
                        {
                            same = i;
                            break;
                        }
                        else
                        {
                            if (i == 4)
                            {
                                w = false;
                                throw new WrongStudentException();
                            }
                        }
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    w = false;
                }
                catch (Exception ex)
                {

                }
            } while (w == false);

            try
            {
                Console.WriteLine("Please enter code of book that you are borrowing.");
                int Q1input3 = int.Parse(Console.ReadLine());
                foreach (int num in booknumber.itemarr)
                {
                    if (Q1input3 == num)
                    {
                        Console.WriteLine($"{studentname.itemarr[same]} have borrowed \"{ bookname.itemarr[Array.IndexOf(booknumber.itemarr, num)]} \" with book code {num}");
                    }
                }
            }
            catch (Exception ex)
            {

            }


        }

    }

    class WrongStudentException : Exception
    {
        public WrongStudentException() : base()
        {
            Console.WriteLine("Incorrect student name or student number");
        }
    }
}
