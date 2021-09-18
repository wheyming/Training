using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPart2
{
    struct employee
    {
        public string name;
        public details employeedetails;
    }

    struct details
    {
        public int salary;
        public string address;
    }

    class Program
    {


        static void Main(string[] args)
        {
            employee[] emp = new employee[2];

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter name " + (i + 1));
                //string na = Console.ReadLine();
                Console.WriteLine("Enter salary " + (i + 1));
                //int s = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter address " + (i + 1));
                //string a = Console.ReadLine();
                Console.WriteLine("\n");
                emp[i].name = Console.ReadLine();//na;
                emp[i].employeedetails.salary = Int32.Parse(Console.ReadLine()); //s;
                emp[i].employeedetails.address = Console.ReadLine(); //a;

            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("\n" + emp[i].name);
                Console.WriteLine(emp[i].employeedetails.salary);
                Console.WriteLine(emp[i].employeedetails.address);
            }
            Console.ReadLine();


            //Stack myStack = new Stack();
            //myStack.Push(Console.ReadLine());
            //myStack.Push(Console.ReadLine());
            //myStack.Push(Console.ReadLine());

            //foreach(string i in myStack)
            //{
            //    Console.WriteLine(i);
            //}

            //myStack.Pop();

            //myStack.Push(Console.ReadLine());

            //foreach(string i in myStack)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("\n" + myStack.Count);

            //Console.ReadLine();







            for (int i = 0; i < 2; i++)
            {
                Student studentmain = new Student();
                Console.WriteLine("Input name of student.");
                string pname = Console.ReadLine();

                Console.WriteLine("Input roll number of student.");
                int pRollnumber = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Input phone number of student.");
                int pPhonenumber = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Input address of student.");
                string pAddress = Console.ReadLine();

                studentmain.assignStudentDetails(pname, pRollnumber, pPhonenumber, pAddress);
                studentmain.getStudentDetails();
                
                Console.ReadLine();
            }

            
            
            for (int i = 0; i < 3; i++)
            {
                Employee employeemain = new Employee();
                Console.WriteLine("Input name of employee.");
                string pname = Console.ReadLine();

                Console.WriteLine("Input employee year of joining.");
                int pyearJoined = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Input salary of employee.");
                int pSalary = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Input address of student.");
                string pAddress = Console.ReadLine();

                employeemain.assignEmployeeDetails(pname, pyearJoined, pSalary, pAddress);
                employeemain.getEmployeeDetails();

                Console.ReadLine();
            }


        }
    }
}
