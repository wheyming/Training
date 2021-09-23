using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3ThursdayDemonstration
{
    class Netflix
    {
        List<string> lst = new List<string>();
        public event EventHandler movieAdded;  // Creating an Event

        public string this[int i]
        {
            get
            {
                return lst[i];
            }
            set
            {
                lst.Add(value);
                if (movieAdded != null)
                {
                    movieAdded?.Invoke(this, null);
                }
            }
        }

        private void showListOfMovies()
        {
            foreach (var movie in lst)
            {
                Console.WriteLine("Movies in netflix: " + movie);
            }
        }
    }
}
