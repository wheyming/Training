using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_Wk2_HTD
{
    
    [Flags] //attributes
    enum enumExample
    {
        Error = 1,
        Warning = 2,
        Exception = 4,
        Information = 8
    }

    abstract class absclass
    {
        public void print()
        {
            Console.WriteLine("In abstract class");
        }

        public virtual void print1()
        {
            Console.WriteLine("In abstract virtual method");
        }
    }

    class inheritfromabstract_overridemethod : absclass
    {
        public override void print1()
        {
            Console.WriteLine("In inheritfromabstract override class");
        }
    }

    class inhertifromabstract_new : absclass
    {
        public new void print1()
        {
            Console.WriteLine("In inheritfromasbstract new class");
        }
    }

    class destructorExample
    {
        public destructorExample()
        {
            Console.WriteLine("This is constructor");
        }

        ~destructorExample() // called when object is being destroyed or at the end of the program.
        {
            Console.WriteLine("This is destructor");
            Console.ReadLine();
        }
    }

    class Program
    {
        static double areaOfCircle(int r, double pi = 3.14) // Simple method
        {
            return (pi * pi * r);
        }

        static void printdata(int a, int b)
        {
            Console.WriteLine("Value of a is " + a);
            Console.WriteLine("Value of b is " + b);
        }

        static void printdata(object a, object b) // Unboxing, converting object to value type.
        {
            if(a is string)
            {
                Console.WriteLine("Object is string");
                //string convertedA = (string)a;
                //convertedA.
                Console.WriteLine("Value of a is " + (string)a);
                Console.WriteLine("Value of b is " + (string)b);
            }

            if(a is int)
            {
                Console.WriteLine("Object is int");
                Console.WriteLine("Value of a is " + (int)a);
                Console.WriteLine("Value of b is " + (int)b);

            }
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Enter radius of circle");
            //int r = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Area of circle is " + areaOfCircle(r, 3.1412));
            //Console.Read();

            //printdata(4, 5);
            //printdata(b: 4, a: 5);

            //printdata((object)5, (object)4); //boxing, converting to object type.
            //printdata((object)"String1", (object)"String2");

            //enumExample temp = enumExample.Exception | enumExample.Information;
            //Console.WriteLine("print 2|3 " + (2 | 3));
            //Console.WriteLine("Print temp value" + temp); // use flags enum when we want multiple values, not just a single enum value. 

            //inheritfromabstract_overridemethod temp1 = new inheritfromabstract_overridemethod();
            ////temp1.print();
            ////temp1.print1();

            //inhertifromabstract_new temp2 = new inhertifromabstract_new();
            ////temp2.print();
            ////temp2.print1();

            //absclass obj = temp2;
            //obj.print1();

            //destructorExample desexample = new destructorExample();
            //Console.WriteLine("Doing something");

            //Console.ReadLine();

            //int a = 2; // method 1
            //int b = 3;
            //int c = a;
            //a = b;
            //b = c;

            //a = a + b; // method 2
            //b = a - b;
            //a = a - b;

            //(a, b) = (b, a); // method 3

        }
    }
}
