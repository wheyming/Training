using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3WednesdayDemonstration
{
    delegate void customdel(string s);
    delegate void customdelwith0param();
    delegate void customdelwith2param(int a, int b);
    delegate int customdelwith2returnparam(int a, int b);

    class Program
    {
        static void Hello(string s)
        {
            Console.WriteLine("Hello " + s);
        }

        static void Bye(string s)
        {
            Console.WriteLine("Bye " + s);
        }


        static void Main1(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            var a = Int32.Parse(Console.ReadLine());
            var b = Int32.Parse(Console.ReadLine());

            Addition addition = new Addition();
            Subtract subtract = new Subtract();
            Multiply multiply = new Multiply();

            // -Multicast Delegate
            delexample del = new delexample(addition.Add);
            del += subtract.Sub;
            del += multiply.Mul;


            //delexample del1 = new delexample(subtract.Sub);

            //delexample del1;
            //del1 = subtract.Sub;

            // -Delegate
            //delexample del4 = new delexample(multiply.Mul);

            //delexample del2 = (i, j) => { Console.WriteLine("In Sample Addition: " + ( a + b)); }


            Operation.performOperation(a, b, del);
            //Operation.performOperation(a, b, del1);

            //addition.Add();
            //subtract.Sub();

            //for (int i = 0; i < a; i++)
            //{
            //    del4(i, b);
            //}

            // Static and instance method assignment to delgate
            //displaydel temp = addition.print1;
            //temp += Addition.print();

            customdel hidel, byedel, multidel, multidelwithoutbye, customdel5; ;

            hidel = Hello;
            byedel = Bye;
            multidel = hidel + byedel;
            multidelwithoutbye = multidel - byedel;



            customdelwith0param customdeltemp = () => { Console.WriteLine("sdfdf"); };
            customdel5 = (string s) => { Console.WriteLine("Input string " + s); };

            customdelwith2param temp2 = (int i, int j) => { Console.WriteLine(i + j); };

            customdeltemp();
            customdeltemp.Invoke();

            customdel5("This is string in anonymous method");
            temp2(5, 6);

            customdelwith2returnparam temp3 = (int i, int j) => { return i + j; };
            var result = temp3(100, 50);
            Console.WriteLine("Result of customdelwith2returnparam: " + result);


            Console.WriteLine("\nInvoking hidel delegate");
            hidel("A");
            Console.WriteLine("\nInvoking byedel delegate");
            byedel("B");
            Console.WriteLine("\nInvoking multidel delegate");
            multidel("C");
            Console.WriteLine("\nInvoking multidelwithoutbye delegate");
            multidelwithoutbye("D");






            Console.ReadLine();
        }

        static public void dosomething()
        {
            Console.WriteLine("Do sdfdf");
        }
    }
}
