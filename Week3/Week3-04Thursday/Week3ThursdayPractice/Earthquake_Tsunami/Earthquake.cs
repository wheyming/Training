using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earthquake_Tsunami
{
    public delegate void calTsu(double x);
    public delegate void calEarthquake(string str);
    class Earthquake
    {
        public event calEarthquake calE;

        public string Place { get; private set; } //Don't want others outside the class to set it.
        public double IE { get; private set; } //Don't want others outside the class to set it. 
        public void callTsunamiProbability()
        {
            Tsunami Tsu = new Tsunami();
            Tsu.Alert += Tsu_Alert; // created a method,
            Tsu.calTsunamiProbability(IE); //Subscribe to event before calling the method. The method is raising the event. 
        }
        
        private void Tsu_Alert(double x)
        {
            if (calE != null)
            {
                string str = "The probability of Tsunami " + x;
                calE.Invoke(str);
            }
        }

        public Earthquake(string Place, double IE)
        {
            this.Place = Place;
            this.IE = IE;
        }
    }

    class Tsunami
    {
        public event calTsu Alert;
        
        public double PT { get; private set; }
        

        public void calTsunamiProbability(double IE)
        {
            Random rand = new Random();
            PT = (IE / 10) * 0.7 + 0.3 * (rand.Next(0, 100) / 100);
            if (Alert != null) // check if there's any subscriber (will give runtime error if null)
            {
                Alert.Invoke(PT);
            }
        }
    }
}
