using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6TuesdayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            User U = new User();
            Admin A = new Admin();
            SuperAdmin SA = new SuperAdmin();

            Console.WriteLine("Would you like to login as\n1.) User\n2.) Admin\n3.) Super Admin");
            int input1 = Convert.ToInt32(Console.ReadLine());
            switch (input1)
            {
                case 1:
                    {
                        bool login = false;
                        Console.WriteLine("Please input user username.");
                        string input1_1 = Console.ReadLine();
                        Console.WriteLine("Please input user password.");
                        string input1_2 = Console.ReadLine();
                        if (Directory.Exists("User\\" + input1_1))
                        {

                            if (File.Exists("User\\" + input1_1 + "\\" + input1_2))
                            {
                                login = true;
                            }
                        }
                        if (login == false)
                        {
                            Console.WriteLine("Incorrect username or password");
                        }
                        if (login == true)
                        {
                            Console.WriteLine("Would you like to\n1.) View task\n2.) Submit task");
                            int input1_3 = Convert.ToInt32(Console.ReadLine());
                            switch (input1_3)
                            {
                                case 1:
                                    {
                                        U.viewTask(input1_1);
                                        break;
                                    }
                                case 2:
                                    {
                                        U.submitTask(input1_1);
                                        break;
                                    }
                            }
                        }
                        break;
                    }
                case 2:
                    {
                        bool login2 = false;
                        Console.WriteLine("Please input admin username.");
                        string input2_1 = Console.ReadLine();
                        Console.WriteLine("Please input admin password.");
                        string input2_2 = Console.ReadLine();
                        if (Directory.Exists("Admin" + input2_1))
                        {

                            if (File.Exists("Admin" + input2_1 + "\\" + input2_2))
                            {
                                login2 = true;
                            }
                        }
                        if (login2 == true)
                        {
                            {
                                A.giveTask();
                            }
                        }
                        break;
                    }
                case 3:
                    {
                        bool login3 = false;
                        Console.WriteLine("Please input super admin username.");
                        string input3_1 = Console.ReadLine();
                        Console.WriteLine("Please input super admin password.");
                        string input3_2 = Console.ReadLine();
                        if (Directory.Exists("SuperAdmin" + input3_1))
                        {

                            if (File.Exists("SuperAdmin" + input3_1 + "\\" + input3_2))
                            {
                                login3 = true;
                            }
                        }
                        if (login3 == true)
                        {
                            Console.WriteLine("Would you like to\n1.) Create user\n2.) Delete user\n3.) Give Task");
                            int input3_3 = Convert.ToInt32(Console.ReadLine());
                            switch (input3_3)
                            {
                                case 1:
                                    {
                                        SA.createUser();
                                        break;
                                    }
                                case 2:
                                    {
                                        SA.deleteUser();
                                        break;
                                    }
                                case 3:
                                    {
                                        SA.giveTask();
                                        break;
                                    }
                            }
                        }
                        break;
                    }
            }
            Console.ReadLine();
        }
    }
}
