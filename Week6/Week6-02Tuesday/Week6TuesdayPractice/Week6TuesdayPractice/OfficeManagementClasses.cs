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
        string task;
        string submit;


        public void viewTask(string ID)
        {
            if (Directory.Exists("User\\" + ID))
            {
                FileStream userFile = new FileStream("User\\" + ID + "\\Task.txt", FileMode.Open, FileAccess.Read);
                StreamReader userFileReadTask = new StreamReader(userFile);
                task = userFileReadTask.ReadToEnd();
                Console.WriteLine(task);
                userFileReadTask.Close();
                userFile.Close();
            }
        }

        public void submitTask(string ID)
        {
            if (Directory.Exists("User\\" + ID))
            {
                Console.WriteLine("Please enter task submission.");
                submit = Console.ReadLine();
                FileStream userFile1 = new FileStream("User\\" + ID + "\\SubmitTask.txt", FileMode.Open, FileAccess.Write);
                StreamWriter userFileSubmitTask = new StreamWriter(userFile1);
                userFileSubmitTask.WriteLine(submit);
                userFileSubmitTask.Flush();
                userFileSubmitTask.Close();
                userFile1.Close();
            }
        }
    }

    class Admin
    {
        string input1;
        public void giveTask()
        {
            Console.WriteLine("Enter userID of user for task giving.");
            input1 = Console.ReadLine();
            if (Directory.Exists("User\\" + input1))
            {
                FileStream userFile = new FileStream("User\\" + input1 + "\\Task.txt", FileMode.OpenOrCreate, FileAccess.Write);
                FileStream userFile1 = new FileStream("User\\" + input1 + "\\SubmitTask.txt", FileMode.OpenOrCreate, FileAccess.Read);
                StreamWriter userFileWriteTask = new StreamWriter(userFile);
                Console.WriteLine($"Enter task for user {input1}");
                string input2 = Console.ReadLine();
                userFileWriteTask.Write($"Task for user {input1}: ");
                userFileWriteTask.WriteLine(input2);
                userFile1.Close();
                userFileWriteTask.Flush();
                userFileWriteTask.Close();
                userFile.Close();
            }
        }
    }

    class SuperAdmin : Admin
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
                if (Directory.Exists("User\\" + input1))
                {
                    Console.WriteLine("Duplicate userID.");
                    duplicateIDbool = true;
                }
            } while (duplicateIDbool == true);
            Console.WriteLine($"Please input password for userID {input1}");
            string input2 = Console.ReadLine();
            Directory.CreateDirectory("User\\" + input1);
            FileStream userFile = new FileStream("User\\" + input1 + "\\" + input2, FileMode.CreateNew);
            userFile.Close();
        }

        public void deleteUser()
        {
            do
            {
                duplicateIDbool = false;
                Console.WriteLine("Please input userID to be deleted.");
                input1 = Console.ReadLine();
                if (!Directory.Exists("User\\" + input1))
                {
                    Console.WriteLine("Invalid userID.");
                    duplicateIDbool = true;
                }
            } while (duplicateIDbool == true);
            Directory.Delete("User\\" + input1);
        }
    }
}
