using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6TuesdayPractice
{
    class User
    {
        public string userID { get; private set; }
        public string password { get; private set; }

        public User(string ID, string pass)
        {
            userID = ID;
            password = pass;
        }

        public void viewTask(string ID, string Password)
        {
            
        }

        public void submitTask(string ID, string Password)
        {

        }
    }

    class Admin
    {
        string input1;
        public void giveTask()
        {
            Console.WriteLine("Enter userID of user for task giving.");
            input1 = Console.ReadLine();
            if (File.Exists(input1 + ".txt"))
            {
                FileStream userFile = new FileStream(input1 + ".txt", FileMode.Append, FileAccess.Write);
                StreamWriter userFileWriteTask = new StreamWriter(userFile);
                userFileWriteTask.WriteLine();
                Console.WriteLine("Enter task for user");
                string input2 = Console.ReadLine();
                userFileWriteTask.Write("Task for user: ");
                userFileWriteTask.WriteLine(input2);
                userFileWriteTask.Flush();
                userFileWriteTask.Close();
                userFile.Close();
            }
        }
    }

    class SuperAdmin
    {
        bool duplicateIDbool;
        string input1;

        public void createUser()
        {
            do
            {
                duplicateIDbool = false;
                Console.WriteLine("Please input userID to be created.");
                input1 = Console.ReadLine();
                if (File.Exists(input1 + ".txt"))
                {
                    Console.WriteLine("Duplicate userID.");
                    duplicateIDbool = true;
                }
            } while (duplicateIDbool == true);
            Console.WriteLine($"Please input password for userID {input1}");
            string input2 = Console.ReadLine();
            FileStream userFile = new FileStream(input1 + ".txt", FileMode.CreateNew, FileAccess.ReadWrite);
            StreamWriter userFilewrite = new StreamWriter(userFile);
            userFilewrite.WriteLine(input2);
            userFilewrite.Flush();
            userFilewrite.Close();
            userFile.Close();
        }

        public void deleteUser()
        {
            do
            {
                duplicateIDbool = false;
                Console.WriteLine("Please input userID to be deleted.");
                input1 = Console.ReadLine();
                if (!File.Exists(input1 + ".txt"))
                {
                    Console.WriteLine("Invalid userID.");
                    duplicateIDbool = true;
                }
            } while (duplicateIDbool == true);
            File.Delete(input1 + ".txt");
        }
    }
}
