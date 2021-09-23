using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3ThursdayDemonstration
{
    public delegate void dele(int a, int b);

    class Program
    {
        //public static bool something(int x)
        //{
        //    return x == 3;
        //}

        static void Main(string[] args)
        {
            Netflix pub = new Netflix();
            Mobile mob = new Mobile();
            Tablet tab = new Tablet();

            tab.SubscribeToEvent(pub);
            mob.SubscribeToEvent(pub);

            pub[0] = "";
            pub[1] = "";
            pub[2] = "";

            Console.ReadLine();

            //List<int> lst = new List<int>();
            //var temp = lst.First((x) =>something(x)); // LINQ example
            //dele obj2 = (a, b) => { Console.WriteLine("This is an exc"); };

            //obj2.Invoke(2, 3); // Invoking anonymous methods
            //obj2(3, 4); // Invoking anonymous methods



        }
    }
}
