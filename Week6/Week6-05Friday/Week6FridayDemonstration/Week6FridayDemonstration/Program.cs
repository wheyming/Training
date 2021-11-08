using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6FridayDemonstration
{
    public class Program
    {
        static void Main(string[] args)
        {
            TakeInput tk = new TakeInput();
            CheckString checkString = new CheckString(tk);



            bool result = checkString.checkValidString();
            if (result)
            {
                Console.WriteLine("Valid String");
            }
            else
            {
                Console.WriteLine("Invalid String");
            }


            Console.ReadLine();
        }
    }
}
