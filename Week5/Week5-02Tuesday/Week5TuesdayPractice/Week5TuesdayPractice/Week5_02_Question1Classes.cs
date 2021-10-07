using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5TuesdayPractice
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
        bool v;
        int same;                
        int Q1input3;
        string Q1input1;
        string Q1input2;
        items<string> studentname = new items<string>();
        items<string> studentnumber = new items<string>();
        items<string> bookname = new items<string>();
        items<int> booknumber = new items<int>();

        public void callingMethod(out int number)
        {

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
                                throw new WrongStudentException();
                            }
                        }
                    }
                    do
                    {
                        Console.WriteLine("Please enter code of book that you are borrowing.");
                        Q1input3 = int.Parse(Console.ReadLine());
                        foreach (int num in booknumber.itemarr)
                        {
                            if (Q1input3 == num)
                            {
                                v = true;
                                break;
                            }
                        }
                        if (v == false)
                        {
                            throw new WrongBookException();
                        }
                    } while (v == false);

                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    w = false;
                }
                catch (WrongStudentException ex)
                {
                    w = false;
                }
                catch (WrongBookException ex)
                {
                    v = false;
                }
                number = Q1input3;
            } while (w == false);
        }

        public void borrowBook(object Q1input3)
        {
            Console.WriteLine($"{studentname.itemarr[same]} have borrowed \"{ bookname.itemarr[Array.IndexOf(booknumber.itemarr, Q1input3)]} \" with book code {Q1input3}");
        }

    }

    class WrongStudentException : Exception
    {
        public WrongStudentException() : base()
        {
            Console.WriteLine("Incorrect student name or student number");
        }
    }

    class WrongBookException : Exception
    {
        public WrongBookException() : base()
        {
            Console.WriteLine("Incorrect book number.");
        }
    }
}
