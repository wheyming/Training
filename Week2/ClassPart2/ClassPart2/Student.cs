using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPart2
{
    class Student
    {
        string name;
        int rollnumber;
        int phonenumber;
        string address;

        public void assignStudentDetails(string iName, int iRollnumber, int iPhonenumber, string iAddress)
        {
            name = iName;
            rollnumber = iRollnumber;
            phonenumber = iPhonenumber;
            address = iAddress;
        }

        public void getStudentDetails()
        {
            Console.WriteLine("\nName: " + name + "\nRoll Number: " + rollnumber + "\nPhone Number: " + phonenumber + "\nAddress: " + address);
        }
    }
}
