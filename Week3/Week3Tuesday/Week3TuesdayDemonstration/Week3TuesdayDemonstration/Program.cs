using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3TuesdayDemonstration
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter gender");
            //var tempgen = Console.ReadLine();
            //Enum.TryParse<GenderEnum>(tempgen, out var genderValue);
            //Console.WriteLine("Entered gender value : " + genderValue);


            //Console.WriteLine("Enter Book Genre: ");
            //Console.WriteLine($"{GenreOfBook.Comedy},{GenreOfBook.Comic},{GenreOfBook.Educational},{GenreOfBook.Short_Stories},{GenreOfBook.Suspense_Thriller}");
            //string tempgenre = Console.ReadLine();


            //string[] strarr = tempgenre.Split(',');
            //GenreOfBook genre = GenreOfBook.Default;
            //for (int i = 0; i < strarr.Length; i++)
            //{
            //    Enum.TryParse<GenreOfBook>(strarr[i], out var parsedValue);
            //    if (genre.HasFlag(GenreOfBook.Default))
            //    {
            //        genre = parsedValue;
            //    }
            //    else
            //    {
            //        genre = genre | parsedValue;
            //    }
            //}

            ////foreach (var s in strarr)
            ////{
            ////    Enum.TryParse<GenreOfBook>(s, out var parsedString);
            ////    genre = parsedString;
            ////}
            ////Console.WriteLine("Selected genre: ", genre);

            //Console.WriteLine(genre);



            //structExample strexm = new structExample();
            //strexm.a = 23;
            //Library.Book tempbook = new Library.Book();
            //tempbook.bookId = 2;



            //// Boxing and Unboxing example
            //int num = 12;
            //object obj = num; //Boxing, turning value type to reference type. 

            //object obj1 = 15; 
            //int num1 = (int)obj1; //Unboxing, reference type to value type.

            add(4.5f, 3.6f);
            add(4, 5);
            add(4.5, 3.2);


            Console.Read();
        }

        public static void add(object a, object b)
        {
            if (a is float temp1 && b is float temp2)
            {
                Console.WriteLine(temp1 + temp2);
            }
            if (a is int temp3 && b is int temp4)
            {
                Console.WriteLine(temp3 + temp4);
            }
            if (a is double temp5 && b is double temp6)
            {
                Console.WriteLine(temp5 + temp6);
            }

        }
    }
}
