using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Examples
{
    public delegate void operation(int res);
    public delegate void operation1(int a, int b);
    public delegate void eventHandler(Events_Examples);
    class AdditionEvent
    {
        public event operation addCompletedEvent;
        public event operation1 performAddEvent;


        public void Add(int a, int b)
        {
            //long standing task
            Console.WriteLine("In AdditionEvent add");
            raiseEvent(a + b);

        }

        private void raiseEvent1(int a, int b)
        {
            if(addCompletedEvent != null)
            {
                addCompletedEvent(a, b);
            }
        }

        private void raiseEvent(int res)
        {
            if addCompletedEvent != null)
            {
                
            }
        }

        private void raiseEventHandler()
        {
           eventexample?.Invoke(this, null);
        }

    }
}
