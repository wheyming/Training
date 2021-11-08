using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6FridayDemonstration
{
    public class TakeInput : ITakeInput
    {
        public string TakeInputMethod()
        {
            Console.WriteLine("Enter string with only ‘(‘ , ‘)’ , ‘{‘ , ‘}’ , ‘[‘ , ‘]’ as character");
            string input = Console.ReadLine();

            return input;
        }
    }
}
