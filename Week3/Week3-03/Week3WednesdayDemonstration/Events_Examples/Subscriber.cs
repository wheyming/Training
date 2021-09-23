using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Examples
{
    class Subscriber
    {
        private Publisher pub;

        public void SubscribeToEvent(Publisher publisher)
        {
            pub = publisher;
            pub.dataAdded += Pub_dataAdded;
        }

        private void Pub_dataAdded(object sender, EventArgs e)
        {
            Console.WriteLine("Data added in list");
        }
    }
}
