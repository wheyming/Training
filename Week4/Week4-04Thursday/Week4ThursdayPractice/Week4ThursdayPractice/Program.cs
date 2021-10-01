using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4ThursdayPractice
{
    class Generic<T>
    {
        public T[] Genarr = new T[10];

        public T this[int index]
        {
            get { return Genarr[index]; }
            set { Genarr[index] = value; }
        }

        public T tvalue { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Generic<int> genint = new Generic<int>();
            genint.tvalue = 5;
            genint.Genarr[0] = 10;
            Console.WriteLine(genint.tvalue);
            Console.WriteLine(genint.Genarr[0]);


            Generic<float> genfloat = new Generic<float>();
            genfloat.tvalue = 5.44f;
            genfloat.Genarr[0] = 10.421f;
            Console.WriteLine(genfloat.tvalue);
            Console.WriteLine(genfloat.Genarr[0]);


            Generic<bool> genbool = new Generic<bool>();
            genbool.tvalue = true;
            genbool.Genarr[0] = false;
            Console.WriteLine(genbool.tvalue);
            Console.WriteLine(genbool.Genarr[0]);


            Console.ReadLine();

        }
    }
}
