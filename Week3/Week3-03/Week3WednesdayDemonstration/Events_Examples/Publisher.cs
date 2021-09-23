using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Examples
{
    class Publisher
    {
        List<int> lst = new List<int>();
        public event EventHandler dataAdded;

        public int this [int i]
        {
            get
            {
                return lst[i];
            }
            set
            {
                lst.Add(value);
                dataAdded?.Invoke(this, null);
            }
        }

    }
}
