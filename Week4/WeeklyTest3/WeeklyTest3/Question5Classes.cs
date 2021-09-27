using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyTest3
{
    delegate void startInputPumpDel();
    delegate void startOutputPumpDel();
    delegate void Capacity();

    class PumpStation
    {
        double Capacity { get; set; }


        event startInputPumpDel startInputEvent;
        event startOutputPumpDel startOutputEvent;
        event Capacity capacityreached;

        public void stopInputPump()
        {
            if (capacityreached != null)
            {
                capacityreached.BeginInvoke(null, null);
            }
        }

        public void stopOutputPump()
        {

        }

        public void startInputPump()
        {
            if(startInputEvent != null)
            {
                startInputEvent.BeginInvoke(null, null);
            }
        }

        public void startOutputPump()
        {
            if (startOutputEvent != null)
            {
                startOutputEvent.BeginInvoke(null, null);
            }
        }
    }
}
