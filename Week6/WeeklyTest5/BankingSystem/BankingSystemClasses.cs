using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    class Customer
    {
        public string name { get; set; }
        public string IDnum { get; set; }
        public int Pinnum { get; set; }
        public double savings { get; set; }
        public Guid chequebookNum { get; set; }

    }

    class BankManagementSystem
    {
        static List<Customer> customerList = new List<Customer>();
        bool IDbool;
        bool loginbool;

        string path = "C:\\Users\\Wei Ming Work\\source\repos\\Training\\Week6\\WeeklyTest5\\BankingSystem";

        public void openAccount()
        {
            Customer customer = new Customer();
            Console.WriteLine("Please enter name: ");
            customer.name = Console.ReadLine();
            do
            {
                IDbool = true;
                Console.WriteLine("Please enter ID number: ");
                customer.IDnum = Console.ReadLine();
                foreach (Customer cus in customerList)
                {
                    if (Equals(cus.IDnum, customer.IDnum) == true)
                    {
                        Console.WriteLine("Repeated ID number, please contact the bank.");
                        IDbool = false;
                        break;
                    }
                }
            } while (IDbool == false);
            Console.WriteLine("Please enter Pinnum: ");
            customer.Pinnum = Convert.ToInt32(Console.ReadLine());
            customerList.Add(customer);

            customer.chequebookNum = new Guid("dddd-dddd-dddd");

            File.AppendAllText(path, Convert.ToString(customer));
        }

        public void withdrawMethod(int IDindex)
        {
            Console.WriteLine("How much money would you like to withdraw?");
            double withdrawinput = Convert.ToDouble(Console.ReadLine());
            if (withdrawinput >= 5000)
            {
                Console.WriteLine("Please withdraw via cheque.");
            }
            else
            {
                if (customerList[IDindex].savings < withdrawinput)
                {
                    Console.WriteLine("Withdrawal amount more than savings.");
                }
                else
                {
                    customerList[IDindex].savings -= withdrawinput;
                }
            }
        }

        public void depositChequeMethod(int IDindex)
        {
            Console.WriteLine("How much money would you like to deposit?");
            double depositinput = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the owner's chequebook number?");
            Console.WriteLine("What is the ID number of chequebook owner?");

        }

        public void depositMethod(int IDindex)
        {
            Console.WriteLine("How much money would you like to deposit?");
            double depositinput = Convert.ToDouble(Console.ReadLine());
            if (depositinput >= 5000)
            {
                Console.WriteLine("Please deposit via cheque.");
            }
            else
            {
                customerList[IDindex].savings += depositinput;
            }
        }

        public void loginAccount(out int loginindex)
        {
            loginbool = false;
            loginindex = -100;
            Console.WriteLine("Please input ID");
            string inputID = Console.ReadLine();
            Console.WriteLine("Please input pin number");
            string inputpin = Console.ReadLine();
            foreach (Customer cus in customerList)
            {
                if (Equals(cus.IDnum, inputID) == true)
                {
                    if (Equals(cus.Pinnum, inputpin) == true)
                    {
                        loginbool = true;
                        loginindex = customerList.IndexOf(cus);
                        break;
                    }
                }
            }
        }
    }
}
