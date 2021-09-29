using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Week4WednesdayDemonstration
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter an emailId");
                var usrEmail = Console.ReadLine();
                validateEmail(usrEmail);
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Exception caught in main"); 
                //Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }

        static void method1(string a)
        {
            try
            {
                validateEmail(a);
                //var str = Int32.Parse("sdf");
                //method2(a);
            }
            catch (InvalidCastException ex)
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in method1");
                throw;
            }
        }
        static void validateEmail(string a)
        {
            Regex regex = new Regex("\\S+@\\S+\\.\\S+/"); // ^[a-zA-z]+$      .{ 1,}@[^.]{ 1,}

            if (regex.IsMatch(a))
            {
                Console.WriteLine("EmailId entered is valid.");
                //validate the email Id
            }
            else
            {
                //throw new ArgumentNullException();
                //throw new NullReferenceException();
                throw new EmailIncorrectException();
            }
        }

        static void method2(int a)
        {
            try
            {
                var res = a / 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in method 2");
                throw;
            }
        }
    }
}
