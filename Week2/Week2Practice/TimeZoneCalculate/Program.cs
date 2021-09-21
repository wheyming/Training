using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeZoneCalculate
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeZone[] tz = new TimeZone[2];
            int i = 0;
            for (i = 0; i < 2; i++)
            {
                Console.WriteLine("Input timezone name " + (i + 1));
                tz[i].name = Console.ReadLine();
                Console.WriteLine("Input " + tz[i].name + " time");
                tz[i].time = Int32.Parse(Console.ReadLine());
            }

            for (i = 0; i < 2; i = (i + 2))
            {
                if (((tz[i].time - tz[i + 1].time) % 100) > 60)
                {
                    Console.WriteLine("The time difference between " + tz[i].name + " and " + tz[i + 1].name + " is " + ((tz[i].time - tz[i + 1].time) / 100) + "." + ((Convert.ToDecimal(tz[i].time - tz[i + 1].time - 40) % 100) / 60 * 10) + " hours.");
                }
                else
                {
                    Console.WriteLine("The time difference between " + tz[i].name + " and " + tz[i + 1].name + " is " + ((tz[i].time - tz[i + 1].time) / 100) + "." + ((Convert.ToDecimal(tz[i].time - tz[i + 1].time) % 100) / 60 * 10) + " hours.");

                }
                Console.ReadLine();

            }
        }
    }
}
