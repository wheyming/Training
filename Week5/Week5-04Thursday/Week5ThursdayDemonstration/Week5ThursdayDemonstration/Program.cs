using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5ThursdayDemonstration
{
    class Program
    {
        static void Main(string[] args)
        {
            String_Bcl_Examples();

            Console.ReadLine();
        }

        static void String_Bcl_Examples()
        {
            List<String> lst = new List<string>();

            //compare
            string str1 = "SampleDemo"; //S 083
            string str2 = "sampleDemo"; //s 115

            lst.Add(str1);
            lst.Add(str2);

            Console.WriteLine("Before sorting");
            foreach(string temp in lst)
            {
                Console.WriteLine(temp);
            }
            var arr = lst.ToArray();
            Array.Sort(arr);
            Console.WriteLine("After sorting");
            foreach(string temp in arr)
            {
                Console.WriteLine(temp);
            }


            int res = str1.CompareTo(str2);

            Console.WriteLine("result of string compare is : " + res);

            string str3 = "a";  //a 065
            string str4 = "b";  //b 066

            int res2 = str3.CompareTo(str4);

            Console.WriteLine("result of string compare is : " + res2);

            string str5 = "b";  //b 066
            string str6 = "a";  //a 065

            int res3 = str5.CompareTo(str6);

            Console.WriteLine("result of string compare is : " + res3);

        }
    }
}
