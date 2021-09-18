using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPart2
{
    class Employee
    {
        string name;
        int yearJoined;
        int salary;
        string address;

        public void assignEmployeeDetails(string iName, int iYearJoined, int iSalary, string iAddress)
        {
            name = iName;
            yearJoined = iYearJoined;
            salary = iSalary;
            address = iAddress;
        }

        public void getEmployeeDetails()
        {
            assignTemp();
            Console.WriteLine("\nName: " + name + "\nRoll Number: " + yearJoined + "\nAddress: " + address);
        }
        private void assignTemp()
        {
            int temp = 10;
        }
    }
}
