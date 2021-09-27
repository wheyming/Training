using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyTest3
{
    public delegate void selectWinnerdel();
    public delegate void getLotteryNumdel();

    class LotteryManager
    {
        public event selectWinnerdel selectWinnerEvent;
        public event getLotteryNumdel getLotteryNumEvent;

        public static string[] lotteryNumbers { get; private set; } = new string[5];
        public static string[] lotteryName { get; private set; } = new string[5];

        public void buyLottery()
        {
            if (getLotteryNumEvent != null)
            {
                getLotteryNumEvent.Invoke();
            }
        }

        public void selectWinner()
        {
            if (selectWinnerEvent != null)
            {
                selectWinnerEvent.Invoke();
            }
        }
    }
}
