using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5MondayPractice
{
    struct FigureValues
    {
        public int UniqueVisitors { get; set; }
        public int NumberofVisit { get; set; }
        public int Pages { get; set; }
        public int Hits { get; set; }
        public int Bandwidth { get; set; }
    }

    class Question2Classes
    {
        static List<FigureValues> FigureValue = new List<FigureValues>();
        int totalVisitor;
        int totalVisits;
        int totalPages;
        int totalHits;
        int totalBandwidth;

        public void setFigureValues()
        {
            for (int i = 0; i < 7; i++)
            {
                FigureValues Day = new FigureValues();
                Console.WriteLine("Enter UniqueVisitors for day " + (i + 1));
                Day.UniqueVisitors = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter NumberofVisit for day " + (i + 1));
                Day.NumberofVisit = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Pages for day " + (i + 1));
                Day.Pages = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Hits for day " + (i + 1));
                Day.Hits = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Bandwidth for day " + (i + 1));
                Day.Bandwidth = Convert.ToInt32(Console.ReadLine());
                FigureValue.Add(Day);
            }
        }

        public void getReport()
        {
            foreach (FigureValues values in Question2Classes.FigureValue)
            {
                totalVisitor += values.UniqueVisitors;
                totalVisits += values.NumberofVisit;
                totalPages += values.Pages;
                totalHits += values.Hits;
                totalBandwidth += values.Bandwidth;
            }

            Console.WriteLine("The total number of Unique Visitors for the week is: " + totalVisitor);
            Console.WriteLine("The total number of Visits for the week is: " + totalVisits);
            Console.WriteLine("The total number of Pages for the week is: " + totalPages);
            Console.WriteLine("The total number of Hits for the week is: " + totalHits);
            Console.WriteLine("The total number of Bandwidth for the week is: " + totalBandwidth);
        }

        public void getGraph()
        {
            int max = Math.Max(Math.Max(Math.Max(Math.Max(totalVisitor, totalVisits), totalPages), totalHits), totalBandwidth);
            for(int i = max; i > 0; i--)
            {
                if (totalVisitor > i)
                {
                    Console.Write("\n|     |\t\t");
                }
                else if (totalVisitor == i)
                {
                    Console.Write("\n=======\t\t");
                }
                else
                {
                    Console.Write("\n       \t\t");
                }
                if (totalVisits > i)
                {
                    Console.Write("|     |\t\t");
                }
                else if (totalVisits == i)
                {
                    Console.Write("=======\t\t");
                }
                else
                {
                    Console.Write("       \t\t");
                }
                if (totalPages > i)
                {
                    Console.Write("|     |\t\t");
                }
                else if (totalPages == i)
                {
                    Console.Write("=======\t\t");
                }
                else
                {
                    Console.Write("       \t\t");
                }
                if (totalHits > i)
                {
                    Console.Write("|     |\t\t");
                }
                else if (totalHits == i)
                {
                    Console.Write("=======\t\t");
                }
                else
                {
                    Console.Write("       \t\t");
                }
                if (totalBandwidth > i)
                {
                    Console.Write("|     |\t\t");
                }
                else if (totalBandwidth == i)
                {
                    Console.Write("=======\t\t");
                }
                else
                {
                    Console.Write("       \t\t");
                }
            }
            Console.WriteLine("\nVistors\t\t Visits\t\t Pages\t\t  Hits\t\tBandwidth");
        }
    }
}
