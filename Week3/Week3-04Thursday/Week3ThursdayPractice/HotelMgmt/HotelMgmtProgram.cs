using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMgmt
{
    class Bill
    {
        double total;
        public void generateBill(int s, int a, int b, int c)
        {
            Console.WriteLine($"The services you have opted for are: {(services)s}");
            total = 0;
            total = (a * 100 + b * 100 + c * 150 + 500) * 1.14;
            Console.WriteLine($"Your total bill for your hotel stay will be ${total}.");
        }
    }


    [Flags]
    enum services
    {
        No_Services = 0,
        Room_Cleaning = 1,
        Food_Delivery = 2,
        Entertainment = 4
    }


    class HotelMgmtProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hotel W.\nWould you like to book a room? (Y / N)");
            char input = Convert.ToChar(Console.ReadLine().ToUpper());
            bool w = true;
            int sum = 0;
            int rc = 0;
            int fd = 0;
            int e = 0;
            if (input == 'Y')
            {
                do
                {
                    Console.WriteLine("Which services would you like?\n1.) Room Cleaning\n2.) Food Delivery\n3.) Entertainment\n4.) Nothing else");
                    int input1 = Int32.Parse(Console.ReadLine());
                    if (input1 == 1)
                    {
                        if (rc == 0)
                        {
                            rc += 1;
                            sum = sum + 1;
                            Console.WriteLine("Room Cleaning added.");
                        }
                        else if (rc == 1)
                        {
                            rc -= 1;
                            sum = sum - 1;
                            Console.WriteLine("Room Cleaning removed.");
                        }
                    }
                    else if (input1 == 2)
                    {
                        if (fd == 0)
                        {
                            fd += 1;
                            sum = sum + 2;
                            Console.WriteLine("Food Delivery added.");
                        }
                        else if (fd == 1)
                        {
                            fd -= 1;
                            sum = sum - 2;
                            Console.WriteLine("Food Delivery removed.");
                        }
                    }
                    else if (input1 == 3)
                    {
                        if (e == 0)
                        {
                            e += 1;
                            sum = sum + 4;
                            Console.WriteLine("Entertainment added.");
                        }
                        else if  (e == 1)
                        {
                            e -= 1;
                            sum = sum - 4;
                            Console.WriteLine("Entertainment removed.");
                        }
                    }
                    else if (input1 == 4)
                    {
                        w = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Input.");
                    }
                } while (w == true);
                Bill b = new Bill();
                b.generateBill(sum, rc, fd, e);
                Console.ReadLine();
            }
            else if (input == 'N')
            {
                Console.WriteLine("Thank you.");
            }
            else
            {
                Console.WriteLine("Incorrect Input.");
            }
        }
    }
}
