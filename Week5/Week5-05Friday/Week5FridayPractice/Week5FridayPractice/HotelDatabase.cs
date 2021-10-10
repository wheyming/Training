using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5FridayPractice
{
    enum HotelRooms
    {
        None = 0,
        Small = 1,
        Medium = 2,
        Large = 3,
        ExtraLarge = 4

    };

    [Flags]
    enum Facilities
    {
        None = 0,
        Food_Delivery = 1,
        Room_Cleaning = 2,
        Entertainment = 4
    };

    class HotelDatabase
    {
        public static List<Customer> HDatabaseStorage = new List<Customer>();
    }

    class Customer
    {
        public string Customername { get; set; }
        public string Customernumber { get; set; }
        public int HotelRoomSelection { get; set; }
        public int FacilitiesSelection { get; set; }
        public DateTime CheckinTime { get; set; }
        public DateTime CheckoutTime { get; set; }

    }
}
