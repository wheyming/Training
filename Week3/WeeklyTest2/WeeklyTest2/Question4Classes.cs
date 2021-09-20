using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyTest2
{
    interface payment
    {
        double processfee { get; set; }
        double purchaseprice { get; set; }
        double finalprice { get; set; }
    }


    enum paymeth
    {
        creditc,
        debitc,
        banktrans
    }

    class Question4Classes
    {
    }
}
