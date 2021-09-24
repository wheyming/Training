using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomEncrypKeyGen
{
    class Generator
    {
        public string publickey;
        string[] genstring = new string[100];
        string this[int i]
        {
            get
            {
                return genstring[i];
            }
            set
            {
                genstring[i] = value;
            }
        }   

        public void Start()
        {

        }

        public void Stop()
        {

        }
    }
}
