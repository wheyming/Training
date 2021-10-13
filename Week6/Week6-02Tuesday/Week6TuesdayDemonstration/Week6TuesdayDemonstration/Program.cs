using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6TuesdayDemonstration
{
    class Program
    {
        static void Main(string[] args)
        {
            //WriteInFile();
            //ReadFromFile();

            smallPractice1();
        }

        private static void smallPractice1()
        {
            bool practicebool;
            do
            {
                practicebool = true;
                Console.WriteLine("Would you like to:\n1.) Create a file\n2.) Read a file\n3.) Write a file\n4.) Append a file\n5.) End program");
                int input1 = Convert.ToInt32(Console.ReadLine());
                switch (input1)
                {
                    case 1:
                        {
                            Console.WriteLine("What is the name of the file you would like to create?");
                            string input2 = Console.ReadLine();
                            FileStream practice = new FileStream(input2 + ".txt", FileMode.CreateNew);
                            practice.Close();
                            break;
                        }
                    case 2:
                        {
                            try
                            {
                                Console.WriteLine("What is the name of the file you woule like to read?");
                                string input3 = Console.ReadLine();
                                FileStream practice1 = new FileStream(input3 + ".txt", FileMode.Open, FileAccess.Read);
                                StreamReader practice1read = new StreamReader(practice1);
                                practice1read.BaseStream.Seek(0, SeekOrigin.Begin);
                                Console.WriteLine(practice1read.ReadToEnd());
                                practice1read.Close();
                                practice1.Close();
                            }
                            catch (IOException)
                            {
                                Console.WriteLine("Invalid file name.");
                            }
                            break;
                        }
                    case 3:
                        {
                            try
                            {
                                Console.WriteLine("What is the name of the file you woule like to write?");
                                string input4 = Console.ReadLine();
                                FileStream practice2 = new FileStream(input4 + ".txt", FileMode.Open, FileAccess.Write);
                                StreamWriter practice2write = new StreamWriter(practice2);
                                Console.WriteLine("Please write the line you wish to write");
                                practice2write.WriteLine(Console.ReadLine());
                                practice2write.Flush();
                                practice2write.Close();
                                practice2.Close();
                            }
                            catch (IOException)
                            {
                                Console.WriteLine("Invalid file name.");
                            }
                            break;
                        }
                    case 4:
                        {
                            try
                            {
                                Console.WriteLine("What is the name of the file you woule like to append?");
                                string input5 = Console.ReadLine();
                                FileStream practice3 = new FileStream(input5 + ".txt", FileMode.Append, FileAccess.Write);
                                StreamWriter practice3append = new StreamWriter(practice3);
                                Console.WriteLine("Please write the line you wish to append");
                                practice3append.WriteLine(Console.ReadLine());
                                practice3append.Flush();
                                practice3append.Close();
                                practice3.Close();
                            }
                            catch (IOException)
                            {
                                Console.WriteLine("Invalid file name.");
                            }
                            break;
                        }
                    case 5:
                        {
                            practicebool = false;
                            break;
                        }
                } 
            } while (practicebool == true) ;
        }

        private static void ReadFromFile()
        {
            FileStream fs = new FileStream("SampleTest.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            Console.WriteLine("Printing content of text file");
            sr.BaseStream.Seek(0, SeekOrigin.Begin); // Moves the cursor to start position of the file and reads from beginning of file
            string str = sr.ReadLine();
            while (str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine(); // To read the subsequent lines. 
            }

            sr.Close();
            fs.Close();
        }

        private static void WriteInFile()
        {
            FileStream fs = new FileStream("SampleTest.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite); // Opens file in readwrite format
            StreamWriter streamWriter = new StreamWriter(fs); // Allows us to read and write.

            Console.WriteLine("Enter the text that you want to write");
            var str1 = Console.ReadLine();

            Console.WriteLine("Enter the text 2 that you want to write");
            var str2 = Console.ReadLine();

            streamWriter.WriteLine(str1);
            streamWriter.WriteLine(str2);
            streamWriter.Flush(); // Push all the bytes into the file before closing to prevent data loss.
            streamWriter.Close(); // To enable others to access the file to write, if there is restriction, if not closed no one else can write it. 
            fs.Close();
        }
    }
}
