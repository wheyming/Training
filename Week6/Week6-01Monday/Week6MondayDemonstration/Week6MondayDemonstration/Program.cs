using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Week6MondayDemonstration
{
    class Program
    {
        static void Main(string[] args)
        {
            //ComplexNumberSystem();
            //GuidExamples();
            //TupleExamples();
            //ValueTupleExamples();

            

            Console.ReadLine();
        }


        private static void GlobalizationCultureExamples()
        {
            var ukEn = new CultureInfo("en-GB");
            var usEn = new CultureInfo("en-US");
            var frFr = new CultureInfo("fr-FR");

            Console.WriteLine(ukEn.DisplayName);
            Console.WriteLine(ukEn.DisplayName);
            Console.WriteLine(frFr.DisplayName);

            Console.WriteLine(usEn.Parent.DisplayName);
            Console.WriteLine(frFr.Parent.DisplayName);

            Console.WriteLine(usEn.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek));
            Console.WriteLine(ukEn.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek));
            Console.WriteLine(frFr.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek));
        }

        private static ValueTuple<int, string, string> getValueTuple2()
        {
            return (1, "someone", "john");
        }
        private static (int, string, string) getValueTuple()
        {
            return (1, "someone", "john");
        }

        private static void BigIntegerExamples()
        {

        }

        private static void print(Tuple<int, int, string> tuple)
        {
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item2);
            Console.WriteLine(tuple.Item3);
        }
        private static Tuple<int, bool> dosomething(int a, int b)
        {
            if (a > b)
            {
                return Tuple.Create(a - b, true);
            }
            else
            {
                return Tuple.Create(a - b, false);
            }
        }
        private static Tuple<int, string, string> returnTuple()
        {
            return Tuple.Create(1, "something", "John");
        }

        private static void ValueTupleExamples()
        {
            var valuetuple1 = (1, "someone", "john");
            Console.WriteLine(valuetuple1.Item1);
            Console.WriteLine(valuetuple1.Item2);
            Console.WriteLine(valuetuple1.Item3);

            ValueTuple<int, string, string> valuetuple2 = (1, "someone", "john");
            (int, string, string) valuetuple3 = (1, "someone", "john");
            (int id, string firstname, string lastname) person1 = (1, "someone", "john");
            Console.WriteLine(person1.id);
            Console.WriteLine(person1.firstname);
            Console.WriteLine(person1.lastname);

            var valuetuple4 = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14);
            Console.WriteLine(valuetuple4.Item13);
            (int id, string fname, string lname) = getValueTuple(); // Not a tuple, just deconstructing return to each individual types.
            Console.WriteLine(id);
            Console.WriteLine(fname);
            Console.WriteLine(lname);
        }
        private static void TupleExamples()
        {
            Tuple<int, double, string> tuple = new Tuple<int, double, string>(1, 5.3, "John");
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item2);
            Console.WriteLine(tuple.Item3);

            var tuple2 = Tuple.Create(1, 1, "John");
            var tuple3 = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12));
            Console.WriteLine(tuple3.Item1);
            Console.WriteLine(tuple3.Item2);
            Console.WriteLine(tuple3.Item3);
            Console.WriteLine(tuple3.Item4);
            Console.WriteLine(tuple3.Item5);
            Console.WriteLine(tuple3.Item6);
            Console.WriteLine(tuple3.Item7);
            Console.WriteLine(tuple3.Rest);
            Console.WriteLine(tuple3.Rest.Item1.Item1);
            Console.WriteLine(tuple3.Rest.Item1.Item2);
            Console.WriteLine(tuple3.Rest.Item1.Item3);

            var res = returnTuple();
            Console.WriteLine(res.Item1);
            Console.WriteLine(res.Item2);
            Console.WriteLine(res.Item3);
        }
        private static void ComplexNumberSystem()
        {
            Complex complex1 = new Complex(12, 6);
            Console.WriteLine("Complex number is : " + complex1);


            Complex complex2 = new Complex(8, 4);
            Console.WriteLine("2nd Complex number is: " + complex2);

            Console.WriteLine("Sum of two complex number: " + (complex1 + complex2));

            Complex complex3 = new Complex(-1, 0);
            Console.WriteLine("Sqrt of complex number: " + Complex.Sqrt(complex3));

            Console.WriteLine("Complex number in format: " + complex2.Real + " + " + complex2.Imaginary + "i");
        }
        private static void ComplexNumberPractice()
        {
            Complex complex1 = new Complex(5, 0);
            Console.WriteLine("1st Complex number is : " + complex1.Real + " + " + complex1.Imaginary + "i");


            Complex complex2 = new Complex(0, 15);
            Console.WriteLine("2nd Complex number is: " + complex2.Real + " + " + complex2.Imaginary + "i");

            Console.WriteLine("Magnitude of 1st complex number: " + Math.Sqrt(Math.Pow(complex1.Real, 2) + Math.Pow(complex1.Imaginary, 2)));
            Console.WriteLine("Multiplication of 1st and 2nd complex number: " + (complex1.Real * complex2.Real + complex1.Imaginary * complex2.Imaginary) + " + " + (complex1.Real * complex2.Imaginary + complex2.Real * complex1.Imaginary) + "i");
            //or (complex1 * complex2).Real "+" (complex1 * complex2).Imaginary + "i";

            Console.ReadLine();
        }
        private static void GuidExamples()
        {
            var guid1 = Guid.NewGuid();
            var guid2 = Guid.NewGuid();

            Console.WriteLine("Equality check: " + (guid1 == guid2));

            var guid3 = Guid.Empty;
            Console.WriteLine("Equality check with empty guid: " + (guid3 == Guid.Empty));

            var bytes = new Byte[16];
            var guid4 = new Guid(bytes);
            Console.WriteLine($"Guid value for: " + guid4);


            for (int i = 0; i < 10; i++)
            {
                var guid = Guid.NewGuid();
                Console.WriteLine($"Guid value for {i + 1} iteration : " + guid);
            }
        }
    }
}
