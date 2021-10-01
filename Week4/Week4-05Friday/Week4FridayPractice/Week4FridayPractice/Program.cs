using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Week4FridayPractice
{
    class Program
    {
        class ThreadPractice
        {
            public void Thread1()
            {
                for(; ;)
                {
                    Thread.Sleep(500);
                    Console.WriteLine("Thread 1");
                }
            }

            public void Thread2()
            {
                for (; ; )
                {
                    Thread.Sleep(500);
                    Console.WriteLine("Thread 2");
                }
            }

        }
        static void Main(string[] args)
        {
            ThreadPractice T = new ThreadPractice();
            Thread T1 = new Thread(T.Thread1);
            Thread T2 = new Thread(T.Thread2);

            T1.Start();
            T2.Start();

            Thread.Sleep(5000);
            T2.Abort();

            Console.ReadLine();

        }
    }
}
