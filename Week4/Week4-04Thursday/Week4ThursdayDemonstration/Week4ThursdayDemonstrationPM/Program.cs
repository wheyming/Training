using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Week4ThursdayDemonstrationPM
{
    class ThreadExample
    {
        public void CallDisplayAsynchronously()
        {
            Console.WriteLine("In CallDisplayAsynchronously");
            Thread t = new Thread(() => { Display(); });
            
            // Different ways to create a Parameterized Thread.
            ParameterizedThreadStart param = new ParameterizedThreadStart(DisplayParameter);
            Thread tp = new Thread(param);

            Thread temp1 = new Thread(new ParameterizedThreadStart(DisplayParameter)); // Same as 17 + 18.

            Thread temp = new Thread((x) => { DisplayParameter(x); }); // same as line 17 + 18 and 20.
            //
            
            
            tp.Priority = ThreadPriority.Highest;
            ThreadStart start = new ThreadStart(Display1);
            
            Thread t1 = new Thread(start);
            
            Console.WriteLine("Before Starting Thread");
            //t.Start();
            tp.Start("This is new");
            //t1.Start();
            Console.WriteLine("Started Thread");
            //t = new Thread(() => { Display2(); });
            //t.Start();
            for (int i = 0; i < 5; i++)
            {
                //Thread.Sleep(5000);
                //if (i == 2)
                //    t.Join();
                Console.WriteLine("I am in main thread");
            }
        }
        public void DisplayParameter(object str)
        {
            for (int i = 0; i < 10; i++)
            {
               // Thread.Sleep(1000);
                Console.WriteLine("I am in display: "+ str.ToString());
            }
        }
        public void Display()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(5000);
                Console.WriteLine("I am in display");
            }
        }
        public void Display1()
        {
            Console.WriteLine("I am in display1");
        }
        public void Display2()
        {
            Console.WriteLine("I am in display2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ThreadExample t = new ThreadExample();
            Console.WriteLine("Calling the Normal Display Method");
            //t.Display();
            Console.WriteLine("Calling the Thread Display Method");
            t.CallDisplayAsynchronously();
            Console.ReadLine();
        }
    }
}
