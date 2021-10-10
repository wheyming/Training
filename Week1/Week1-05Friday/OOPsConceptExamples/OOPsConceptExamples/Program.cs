using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConceptExamples
{
    // Access Modifiers -> Public, Private, Internal and Protected. 
    public class Car
    {
        private int numberOfWheels;

        public void setNumberOfWheels (int input)
        {
            numberOfWheels = input;
        }
        
        public void getNumberofWheels()
        {
            Console.WriteLine("Number of wheels: " + numberOfWheels);
        }

        
    }

    internal class Bike
    {
        private bool hasDigitalDisplay;

        internal void setHasDigitalDisplay (bool input)
        {
            hasDigitalDisplay = input;
        }

        internal void getHasDigitalDisplay()
        {
            Console.WriteLine("Number of wheels: " + hasDigitalDisplay);
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            int i = 5;
            Car carObject = new Car();
            Console.WriteLine("Enter number of wheels required.");
            int input = Int32.Parse(Console.ReadLine());

            carObject.setNumberOfWheels(input);
            carObject.getNumberofWheels();
            Console.ReadKey();

            Bike bikeObject = new Bike();
            /*
            bikeObject.setHasDigitalDisplay(input);
            bikeObject.getHasDigitalDisplay();*/
            Console.ReadKey();
        }
    }
}
