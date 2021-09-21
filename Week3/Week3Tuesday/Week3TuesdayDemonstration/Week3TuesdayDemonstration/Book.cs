using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3TuesdayDemonstration
{
    enum GenderEnum
    {
        Default,  // If it fails to parse the string to your enum, it will automatically assign this value. 
        Male,
        Female,
        Others
    }

    [Flags]
    enum GenreOfBook
    {
        Default = 1,
        Educational = 2,
        Suspense_Thriller = 4,
        Comic = 8,
        Comedy = 16,
        Short_Stories = 32
    }


    struct structExample
    {
        public int a;
    }

    class Library
    {
        public struct Book
        {
            public int bookId;
        }
    }

}
