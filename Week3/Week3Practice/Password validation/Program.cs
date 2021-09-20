using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_validation
{
    class Program
    {
        static void Main(string[] args)
        {
            string accepted;
            bool test;
            do
            {
                test = true;
                Console.WriteLine("Input your password");
                string password = Console.ReadLine();

                if (password.Length < 6 || password.Length > 24)
                {
                    Console.WriteLine("Please create a password between 6 to 24 characters.");
                    test = false;
                }

                int j = 0;
                int k = 0;
                int l = 0;
                for (int i = 0; i < password.Length; i++)
                {
                    if (Char.IsUpper(password[i]))
                    {
                        j++;
                    }
                    if (Char.IsLower(password[i]))
                    {
                        k++;
                    }
                    if (Char.IsDigit(password[i]))
                    {
                        l++;
                    }
                    else
                    {
                        continue;
                    }
                }

                if (j == 0 || k == 0 || l == 0)
                {
                    Console.WriteLine("Please create a password with at least one uppercase letter, one lowercase letter and one digit.");
                    test = false;
                }

                for (int i = 0; i < (password.Length - 2); i++)
                {
                    if (Equals(password[i], password[i + 1]) && Equals(password[i + 1], password[i + 2]))
                    {
                        Console.WriteLine("Please create a password with maximum of 2 repeated characters.");
                        test = false;
                    }
                }
                accepted = password;
            } while (test == false);
            Console.WriteLine(accepted + " is a valid password");
            Console.ReadLine();
        }
    }
}
