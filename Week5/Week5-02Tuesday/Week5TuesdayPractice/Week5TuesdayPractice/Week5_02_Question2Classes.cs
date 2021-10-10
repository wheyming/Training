using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5TuesdayPractice
{
    public delegate void lowBloodDel(int Blood, string Bloodtype);

    class BloodBank
    {
        public event lowBloodDel lowBloodEvent;

        static int BloodA = 4;
        static int BloodB = 4;
        static int BloodAB = 4;
        static int BloodO = 4;

        public void lowBloodStock()
        {

            for (; ; )
            {
                if (BloodA < 5)
                {
                    if (lowBloodEvent != null)
                    {
                        lowBloodEvent.Invoke(BloodA, "A");
                    }
                }
                if (BloodB < 5)
                {
                    if (lowBloodEvent != null)
                    {
                        lowBloodEvent.Invoke(BloodB, "B");
                    }
                }
                if (BloodAB < 5)
                {
                    if (lowBloodEvent != null)
                    {
                        lowBloodEvent.Invoke(BloodAB, "AB");
                    }
                }
                if (BloodO < 5)
                {
                    if (lowBloodEvent != null)
                    {
                        lowBloodEvent.Invoke(BloodO, "O");
                    }
                }
            }
        }

        public void BloodBank_lowBloodEvent(int Blood, string Bloodtype)
        {
            Console.WriteLine("Warning. Blood type {0} is low with {1} units left only.", Bloodtype, Blood);
        }

        public void bloodBankSystem()
        {
            
        }
    }
}
