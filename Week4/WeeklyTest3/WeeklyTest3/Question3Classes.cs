using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WeeklyTest3
{
    delegate void stopDel();
    delegate void startDel();

    class Timer
    {
        public event stopDel stopEvent;
        public event startDel startEvent;


        // needed for methods to run asynchronously, and event is not able to access this value if I set it private, will think about alternative solutions.
        static public /* private required */int Counter { get; set; } 


        public void start()
        {   
            Program.isCounterRunning = true;
            if (startEvent != null)
            {
                startEvent.BeginInvoke(null, null);
            }

        }

        public void stop()
        {
            if (stopEvent != null)
            {
                stopEvent.Invoke();
            }
            Thread.Sleep(200); // To enable increment counter to catch up before printing value;
            Console.WriteLine($"Counter value is: {Counter}.");
        }
    }
}
