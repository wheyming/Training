using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earthquake_Tsunami
{
    class QuakeTsuProgram
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double input1 = Convert.ToDouble(Console.ReadLine());
            Earthquake Earth = new Earthquake(input, input1);
            Earth.calE += Earth_calE; // subscribing to an event
            Earth.callTsunamiProbability(); // calling the function and raising the event.
            Console.ReadLine();

        }

        private static void Earth_calE(string str)
        {
            Console.WriteLine(str);
        }
    }
}
// Main class, main class created earthquake class, earthquake has the place and intensity,
// earthquake has event, created another class tsunami and calculated probability
// event. earthquake class raised another, event chaining. 1.) normal event 2.) event chaining. 3.) 
// Add a breakpoint, or add more console logs. 