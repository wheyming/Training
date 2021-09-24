using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Week3ThursdayPractice
{
    delegate void Notify();

    class Counter
    {
        public void increaseCount()
        {            
            for (int i = 1; ; i++)
            {
                Thread.Sleep(5000);
                Console.WriteLine(i);
                if (i % 20 == 0)
                {
                    EventRaised?.Invoke();
                }
            }
        }

        public event Notify EventRaised;
    }
}
