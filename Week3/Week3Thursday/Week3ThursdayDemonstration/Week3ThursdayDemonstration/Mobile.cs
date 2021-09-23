using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3ThursdayDemonstration
{
    class Mobile
    {
        private Netflix pub;

        public void SubscribeToEvent(Netflix publisher)
        {
            pub = publisher;
            pub.movieAdded += Pub_dataAdded;
        }

        private void Pub_dataAdded(object sender, EventArgs e)
        {
            Console.WriteLine("Movie added in netflix, showing notification in mobile device");
        }

        public void UnsubscribeToEvent()
        {
            pub.movieAdded -= Pub_dataAdded;
        }
    }
}
