using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6WednesdayPractice
{
    class User
    {
        bool duplicatebool;
        
        public void signUpUser()
        {
            string userIDinput;
            string passwordinput;
            string phonenumberinput;
            string emailinput;
            
            do
            {
                duplicatebool = false;
                Console.WriteLine("Please input userID to be created.");
                userIDinput = Console.ReadLine();
                if (Directory.Exists("User\\" + userIDinput))
                {
                    Console.WriteLine("Duplicate userID.");
                    duplicatebool = true;
                }
            } while (duplicatebool == true);
            do
            {
                duplicatebool = false;
                Console.WriteLine("Please input email.");
                emailinput = Console.ReadLine();
                if ((File.ReadAllText("User\\Email.txt")).Contains(emailinput) == true)
                {
                    Console.WriteLine("Duplicate email.");
                    duplicatebool = true;
                }
            } while (duplicatebool == true);
            do
            {
                duplicatebool = false;
                Console.WriteLine("Please input phone number.");
                phonenumberinput = Console.ReadLine();
                if ((File.ReadAllText("User\\PhoneNumber.txt")).Contains(phonenumberinput) == true)
                {
                    Console.WriteLine("Duplicate phone number.");
                    duplicatebool = true;
                }
            } while (duplicatebool == true);
            Console.WriteLine($"Please input password for userID {userIDinput}");
            passwordinput = Console.ReadLine();
            Directory.CreateDirectory("User\\" + userIDinput);
            FileStream userFile = new FileStream("User\\" + userIDinput + "\\" + passwordinput, FileMode.CreateNew);
            FileStream emailFile = new FileStream("User\\" + userIDinput + "\\" + emailinput, FileMode.CreateNew);
            FileStream phoneFile = new FileStream("User\\" + userIDinput + "\\" + phonenumberinput, FileMode.CreateNew);
            userFile.Close();
            emailFile.Close();
            phoneFile.Close();
            emailFile = new FileStream("User\\Email.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sr = new StreamWriter(emailFile);
            sr.WriteLine(emailinput);
            sr.Flush();
            sr.Close();
            emailFile.Close();
            phoneFile = new FileStream("User\\PhoneNumber.txt", FileMode.Append, FileAccess.Write);
            sr = new StreamWriter(phoneFile);
            sr.WriteLine(phonenumberinput);
            sr.Flush();
            sr.Close();
            phoneFile.Close();        
        }

        public void bookTickets()
        {

        }
    }

    class Admin
    {
        string input1;
        public void viewBookingDetails()
        {
            
        }
    }
}
