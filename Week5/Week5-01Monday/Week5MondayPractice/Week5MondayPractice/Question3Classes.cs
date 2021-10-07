using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5MondayPractice
{
    delegate void passwordDel(string password);

    class Question3Classes
    {
        public event passwordDel passwordEvent;

        public void Question3app(string password)
        {
            if (passwordEvent != null)
            {
                passwordEvent.Invoke(password);
            }
        }
        
        public void PasswordAccepted(string password)
        {
            Console.WriteLine($"{password} is a valid password.");
        }


        public void PasswordValidationSpecialChar(string password)
        {
            char[] specialchar = new char[] { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '+', '=', '_', '-', '{', '}', '[', ']', ':', ';', '"', '\'', '?', '<', '>', ',', '.' };
            bool q = true;
            foreach (char c in password)
            {
                for (int i = 0; i < specialchar.Length; i++)
                {
                    if (c == specialchar[i])
                    {
                        q = false;
                        break;
                    }
                }
                if (q == false)
                {
                    break;
                }
            }
            if (q == true)
            {
                throw new SpecialCharException();
            }
        }
        public void PasswordValidationDigit(string password)
        {
            int l = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsDigit(password[i]))
                {
                    l++;
                    break;
                }
            }
            if (l == 0)
            {
                throw new DigitException();
            }
        }
        public void PasswordValidationNumber(string password)
        {
            if (password.Length < 6 || password.Length > 24)
            {
                throw new NumberofCharException();
            }
        }
        public void PasswordValidationLower(string password)
        {
            int k = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsLower(password[i]))
                {
                    k++;
                    break;
                }
            }
            if (k == 0)
            {
                throw new LowercaseException();
            }
        }
        public void PasswordValidationRepeatedTwo(string password)
        {
            for (int i = 0; i < (password.Length - 2); i++)
            {
                if (Equals(password[i], password[i + 1]) && Equals(password[i + 1], password[i + 2]))
                {
                    throw new RepeatedTwoException();
                }
            }
        }
        public void PasswordValidationUpper(string password)
        {
            {

                int j = 0;
                for (int i = 0; i < password.Length; i++)
                {
                    if (Char.IsUpper(password[i]))
                    {
                        j++;
                        break;
                    }
                }
                if (j == 0)
                {
                    throw new UppercaseException();
                }
            }
        }
    }

    class UppercaseException : Exception
    {
        public UppercaseException()
        {
            Console.WriteLine("Please create a password with at least one uppercase letter.");
        }
    }

    class LowercaseException : Exception
    {
        public LowercaseException()
        {
            Console.WriteLine("Please create a password with at least one lowercase letter.");
        }
    }

    class DigitException : Exception
    {
        public DigitException()
        {
            Console.WriteLine("Please create a password with at least one digit.");
        }
    }

    class SpecialCharException : Exception
    {
        public SpecialCharException()
        {
            Console.WriteLine("Please create a password with at least one special character.");
        }
    }

    class RepeatedTwoException : Exception
    {
        public RepeatedTwoException()
        {
            Console.WriteLine("Please create a password with maximum of 2 repeated characters.");
        }
    }

    class NumberofCharException : Exception
    {
        public NumberofCharException()
        {
            Console.WriteLine("Please create a password between 6 to 24 characters.");
        }
    }
}
