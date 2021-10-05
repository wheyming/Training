using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3FridayPractice
{
    class studentname
    {
        public string[] stunamearr;

        public string this[int index]
        {
            get { return stunamearr[index]; }
            set { stunamearr[index] = value; }
        }
    }

    class studentnumber
    {
        public string[] stunumarr;

        public string this[int index]
        {
            get { return stunumarr[index]; }
            set { stunumarr[index] = value; }
        }
    }

    class bookname
    {
        public string[] booknamearr;

        public string this[int index]
        {
            get { return booknamearr[index]; }
            set { booknamearr[index] = value; }
        }
    }

    class booknumber
    {
        public int[] booknumarr;

        public int this[int index]
        {
            get { return booknumarr[index]; }
            set { booknumarr[index] = value; }
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
            studentname studentname = new studentname();
            studentnumber studentnumber = new studentnumber();
            bookname bookname = new bookname();
            booknumber booknumber = new booknumber();
            studentname.stunamearr = new string[5] { "A", "B", "C", "D", "E" };
            studentnumber.stunumarr = new string[5] { "1110", "1111", "1112", "1113", "1114" };
            bookname.booknamearr = new string[8] { "AAAAAAAA", "AAAAAB", "AHASJHA", "AAAAASAA", "AAASA", "AAEAA", "AESA", "AASJJA" };
            booknumber.booknumarr = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };


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
                        if ((Q1input1 == studentname.stunamearr[i]) && (Q1input2 == studentnumber.stunumarr[i]))
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
                foreach (int num in booknumber.booknumarr)
                {
                    if (Q1input3 == num)
                    {
                        Console.WriteLine($"{studentname.stunamearr[same]} have borrowed \"{ bookname.booknamearr[Array.IndexOf(booknumber.booknumarr, num)]} \" with book code {num}");
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

