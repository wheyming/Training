using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetEvents
{
    class IntEventArgs : EventArgs
    {
        public IntEventArgs(int number)
        {
            someIntProperty = number;
        }

        public int someIntProperty { get; private set; }
    }

    class Publisher
    {
        public event EventHandler<IntEventArgs> numberModifiedEvent;

        public void doSomething(int a)
        {
            a = a * 100;
            IntEventArgs arg = new IntEventArgs(a);

            numberModifiedEvent(this, arg);
        }
    }

    /* class Sample
    {
        public void someMethod()
        {
            Program p = new Program();
            p.someEvent += P_someEvent;
        }

        private void P_someEvent(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    } */
}
