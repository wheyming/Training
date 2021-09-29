using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4TuesdayPractice
{
    class Question5Classes
    {
        int[] idarr = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        string[] namearr = new string[10] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
        string[] addarr = new string[10] { "AA", "BB", "CC", "DD", "EE", "FF", "GG", "HH", "II", "JJ" };

        public string this[int index]
        {
            get
            {
                Console.WriteLine("name");
                return namearr[index];
            }
            set
            {
                namearr[index] = value;
            }
        }

        public string this[float index]
        {
            get
            {
                Console.WriteLine("add");
                return addarr[Convert.ToInt32(index)];
            }
            set 
            {
                addarr[Convert.ToInt32(index)] = value;
            }
        }

        public int this[double index]
        {
            get
            {
                Console.WriteLine("id");
                return idarr[Convert.ToInt32(index)];
            }
            set
            {
                idarr[Convert.ToInt32(index)] = value;
            }
        }
    }
}
