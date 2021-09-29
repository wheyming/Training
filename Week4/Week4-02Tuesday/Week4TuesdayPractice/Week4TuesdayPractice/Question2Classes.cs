using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week4TuesdayPractice
{
    class Question2Classes
    {
        void createDirectory()
        {
            string directoryPath = Console.ReadLine();
            try
            {
                DirectoryInfo di = Directory.CreateDirectory(directoryPath);

            }
            catch
            {

            }
        }
        void createFile()
        {
            bool w;
            do
            {
                w = true;
                try
                {
                    string filePath = Console.ReadLine();
                    FileStream di = File.Create(filePath);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Please input a valid string. {0}", ex.Message);
                    w = false;
                }
                catch (UnauthorizedAccessException ex)
                {
                    Console.WriteLine("You are not allowed access to the file. {0}", ex.Message);
                    w = false;
                }
            } while (w == false);
        }

    }
}
