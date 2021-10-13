using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    class BankingSystemProgram
    {
        static void Main(string[] args)
        {
            BankManagementSystem BMS = new BankManagementSystem();
            int loginindex;
            Console.WriteLine("Are you a new customer? (Y/N)");
            char input1 = Char.ToUpper(Convert.ToChar(Console.ReadKey()));
            if (input1 == 'Y')
            {
                BMS.openAccount();
            }
            if (input1 == 'N')
            {
                do
                {
                    BMS.loginAccount(out loginindex);
                } while (loginindex < 0);
                Console.WriteLine("Would you like to \n1.) Withdraw \n2.) Deposit?");
                string input2 = Console.ReadLine();
                BMS.withdrawMethod(loginindex);
                BMS.depositMethod(loginindex);
                BMS.depositChequeMethod(loginindex);
            }

        }
    }
}
