using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WeeklyTest4
{
    class Question1Classes
    {
        static int[] ThreadID = new int[10];
        static int counter = 0;
        static Thread[] threads = new Thread[10];
        public void createThread()
        {
                threads[counter] = new Thread(Threads);
                ThreadID[counter] = (counter);
                counter++;
                Console.WriteLine("A thread of ID {0} has been created.", counter);
        }
        public void destroyThread(int destroythreadinput)
        {
            threads[destroythreadinput].Abort();
        }
        public void Threads()
        {
            for (; ; )
            {
                Thread.Sleep(5000);
                Console.WriteLine("Thread is running");
            }
        }

    }
}
