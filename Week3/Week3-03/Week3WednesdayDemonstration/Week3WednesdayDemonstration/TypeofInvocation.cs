using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Week3WednesdayDemonstration
{
    class TypeofInvocation
    {
        delegate int customdel(int a);

        public static int returnsquare(int a)
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Value of a after incrememnt " + (a++));
                Thread.Sleep(2000);
            }
            return a * a;
        }


        static void Main(string[] args)
        {
            //Syncronousdelegateexample();
            Asyncronousdelegateexample();

            Console.ReadLine();
        }


        private static void Asyncronousdelegateexample()
        {
            customdel del = new customdel(returnsquare);

            Console.WriteLine("Starting to execute customdel");
            IAsyncResult asyncResult = del.BeginInvoke(4, null, null);
            Console.WriteLine("customdel execution ended");
            int result = del.EndInvoke(asyncResult);
            Console.WriteLine("Square of number is " + result);

            Console.ReadLine();

        }

        private static void Syncronousdelegateexample()
        {
            customdel del = new customdel(returnsquare);

            Console.WriteLine("Starting to execute customdel");
            del(4);
            Console.WriteLine("customdel execution ended");

            Console.ReadLine();


        }
    }
}
