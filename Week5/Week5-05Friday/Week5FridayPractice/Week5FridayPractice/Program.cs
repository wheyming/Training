using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5FridayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            bool system = true;
            bool facilities = true;
            bool facilities1 = true;
            bool facilities2 = true;
            bool facilities3 = true;
            bool checkinbool;
            bool checkoutbool;

            Customer customer1 = new Customer();
            customer1.Customername = "John";
            customer1.Customernumber = "1";
            customer1.HotelRoomSelection = 1;
            customer1.FacilitiesSelection = 6;
            customer1.CheckinTime = DateTime.Parse("10 / 24 / 21 14:00");
            customer1.CheckoutTime = DateTime.Parse("10 / 10 / 21 14:00");
            HotelDatabase.HDatabaseStorage.Add(customer1);

            customer1 = new Customer();
            customer1.Customername = "John";
            customer1.Customernumber = "1";
            customer1.HotelRoomSelection = 3;
            customer1.FacilitiesSelection = 2;
            customer1.CheckinTime = DateTime.Parse("11 / 24 / 21 14:00");
            customer1.CheckoutTime = DateTime.Parse("11 / 25 / 21 14:00");
            HotelDatabase.HDatabaseStorage.Add(customer1);

            customer1 = new Customer();
            customer1.Customername = "Steven";
            customer1.Customernumber = "2";
            customer1.HotelRoomSelection = 3;
            customer1.FacilitiesSelection = 2;
            customer1.CheckinTime = DateTime.Parse("12 / 24 / 21 15:00");
            customer1.CheckoutTime = DateTime.Parse("1 / 12 / 21 16:00");
            HotelDatabase.HDatabaseStorage.Add(customer1);


            do
            {
                Console.WriteLine("Welcome to Hotel xxxxxxx");
                Console.WriteLine("What would you like to do?\n1.)Book a room\n2.)Retrieve details\n3.)Exit");
                int input1 = Convert.ToInt32(Console.ReadLine());
                switch (input1)
                {
                    case 1:
                        {
                            Customer customer = new Customer();
                            Console.WriteLine("What is customer's name?");
                            string input1_1 = Console.ReadLine();
                            Console.WriteLine("What is customer's number?");
                            string input1_2 = Console.ReadLine();
                            customer.Customername = input1_1;
                            customer.Customernumber = input1_2;
                            Console.WriteLine("Which type of room did customer book?\n1.) Small\n2.) Medium\n3.) Large\n4.) Extra Large");
                            int input1_3 = Convert.ToInt32(Console.ReadLine());
                            customer.HotelRoomSelection = input1_3;
                            do
                            {
                                Console.WriteLine("Which type of facilities would customer like to opt for?\n1.) Food Delivery\n2.) Room Cleaning\n3.) Entertainment\n4.) Nothing else");
                                int input1_4 = Convert.ToInt32(Console.ReadLine());
                                switch (input1_4)
                                {
                                    case 1:
                                        {
                                            if (facilities1 == true)
                                            {
                                                customer.FacilitiesSelection += 1;
                                                facilities1 = false;
                                            }
                                            else
                                            {
                                                customer.FacilitiesSelection -= 1;
                                                facilities1 = true;
                                            }
                                            break;
                                        }
                                    case 2:
                                        {
                                            if (facilities2 == true)
                                            {
                                                customer.FacilitiesSelection += 2;
                                                facilities2 = false;
                                            }
                                            else
                                            {
                                                customer.FacilitiesSelection -= 2;
                                                facilities2 = true;
                                            }
                                            break;
                                        }
                                    case 3:
                                        {
                                            if (facilities3 == true)
                                            {
                                                customer.FacilitiesSelection += 4;
                                                facilities3 = false;
                                            }
                                            else
                                            {
                                                customer.FacilitiesSelection -= 4;
                                                facilities3 = true;
                                            }
                                            break;
                                        }
                                    case 4:
                                        {
                                            facilities = false;
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("Incorrect input.");
                                            break;
                                        }
                                }
                            } while (facilities == true);
                            
                            do
                            {
                                Console.WriteLine("Desired check in date and time? ( MM/DD/YY HH:mm )");
                                string input1_5 = Console.ReadLine();
                                if (DateTime.TryParse(input1_5, out DateTime checkin) == true)
                                {
                                    customer.CheckinTime = checkin;
                                    checkinbool = true;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid date or time input");
                                    checkinbool = false;
                                }
                            } while (checkinbool == false);
                            do
                            {
                                Console.WriteLine("Desired check out date and time? ( MM/DD/YY HH:mm )");
                                string input1_6 = Console.ReadLine();
                                if (DateTime.TryParse(input1_6, out DateTime checkout) == true)
                                {
                                    customer.CheckoutTime = checkout;
                                    checkoutbool = true;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid date or time input");
                                    checkoutbool = false;
                                }
                            } while (checkoutbool == false);
                            HotelDatabase.HDatabaseStorage.Add(customer);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("What is customer's name?");
                            string input2_1 = Console.ReadLine();
                            Console.WriteLine("What is customer's number?");
                            string input2_2 = Console.ReadLine();
                            foreach (Customer c in HotelDatabase.HDatabaseStorage)
                            {
                                if (c.Customername == input2_1)
                                {
                                    if (c.Customernumber == input2_2)
                                    {
                                        Console.WriteLine($"\n{c.Customername} with number {c.Customernumber} has booked " +
                                            $"\n{(HotelRooms)c.HotelRoomSelection} Room " +
                                            $"\nFacilities: {(Facilities)c.FacilitiesSelection} " +
                                            $"\nCheckin timing {c.CheckinTime}" +
                                            $"\nCheckout timing {c.CheckoutTime}.\n");
                                    }
                                }
                            }
                            break;
                        }
                    case 3:
                        {
                            system = false;
                            break;
                        }
                }
            } while (system == true);
            Console.ReadLine();
        }
    }
}
