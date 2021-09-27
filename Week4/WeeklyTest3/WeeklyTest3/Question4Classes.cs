using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyTest3
{
    class Package
    {
        int[] trackingID { get; set; }
        string[] senderName { get; set; }
        string[] receiverName { get; set; }
        string[] receiverAdd { get; set; }
    }
    class PackageManager
    {
        List<Package> Packages = new List<Package>();
        public void receivePackage(int trackingID)
        {

        }
        public void dispatchPackage(int trackingID)
        {

        }


    }
}
