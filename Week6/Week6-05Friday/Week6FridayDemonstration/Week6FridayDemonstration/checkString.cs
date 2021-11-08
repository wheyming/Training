using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6FridayDemonstration
{
    public class CheckString
    {
        private ITakeInput _takeInput;

        public CheckString(ITakeInput takeInput)
        {
            _takeInput = takeInput;
        }


        public bool checkValidString()
        {
            string input = _takeInput.TakeInputMethod();//new ITakeInput //Method

            bool check = true;
            bool startcheck = false;
            Stack<char> stck = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                startcheck = true;
                if (input[i] == '(' || input[i] == '[' || input[i] == '{')
                {
                    stck.Push(input[i]);
                }
                else
                {
                    var temp = stck.Pop();
                    if (input[i] == ')' && temp == '(')
                    {
                        continue;
                    }
                    if (input[i] == '}' && temp == '{')
                    {
                        continue;
                    }
                    if (input[i] == ']' && temp == '[')
                    {
                        continue;
                    }
                    else
                    {
                        check = false;
                        break;
                    }
                }
            }
            if (startcheck == true && check == true && stck.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
