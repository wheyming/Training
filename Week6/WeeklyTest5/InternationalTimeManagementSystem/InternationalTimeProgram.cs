using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalTimeManagementSystem
{
    class InternationalTimeProgram
    {
        static void Main(string[] args)
        {
            for (; ;)
            {
                Console.WriteLine("Enter the longitude of current location.");
                double input1 = Convert.ToDouble(Console.ReadLine());
                DateTime timenow = DateTime.UtcNow;
                timenow = timenow.AddHours(input1 / 15);
                Console.WriteLine("The current time at longitude {0} is {1}.", input1, timenow);
            }
        }
    }
}
