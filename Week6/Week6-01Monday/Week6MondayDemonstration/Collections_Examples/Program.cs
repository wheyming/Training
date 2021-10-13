using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Examples
{
    class student
    {
        public int id;
        public string name;
        public student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //ExampleofList();
            //ExampleofStack();
            //ExampleofQueue();
            ExampleofDictionary();


            Console.ReadLine();

        }

        private static void ExampleofDictionary()
        {
            Dictionary<int, List<int>> dicttemp = new Dictionary<int, List<int>>();
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < 10; i++)
            {
                if (dict.ContainsKey(i))
                {
                    dict.Add(i, i * 10);
                }
            }
            if (dict.ContainsKey(4))
            {
                Console.WriteLine("Key value pair present in dictionary");
            }
            foreach (KeyValuePair<int, int> kvp in dict)
            {
                Console.WriteLine($"Key is {kvp.Key} and value is {kvp.Value}");
            }

            var lstValues = dict.Values.ToList();
            foreach (int i in lstValues)
            {
                Console.WriteLine($"Values are {i}");
            }
            var lstKeys = dict.Keys.ToList();
            foreach (int i in lstKeys)
            {
                Console.WriteLine($"Values are {i}");
            }


            int[] arr = new int[] { 0, 0, 1, 2, 2, 5, 7, 8, 4, 4, 7, 8, 4, 8, 9, 2, 3, 4, 7, 8, 4, 3 };
            Dictionary<int, int> dictarr = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (dictarr.ContainsKey(arr[i]))
                {
                    dictarr[arr[i]]++;
                }
                else
                {
                    dictarr.Add(arr[i], 1);
                }
            }
            foreach (KeyValuePair<int, int> kvp in dictarr)
            {
                Console.WriteLine($"Key is {kvp.Key} and value is {kvp.Value}");
            }

            SortedDictionary<int, int> sortedDict = new SortedDictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (sortedDict.ContainsKey(arr[i]))
                {
                    sortedDict[arr[i]]++;
                }
                else
                {
                    sortedDict.Add(arr[i], 1);
                }
            }
            foreach (KeyValuePair<int, int> kvp in sortedDict)
            {
                Console.WriteLine($"Key is {kvp.Key} and value is {kvp.Value}");
            }

            dict.Count();
            dict.Clear();

            dicttemp.Add(1, { 1 };);

        }

        private static void ExampleofQueue()
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            Console.WriteLine("Size of stack: " + q.Count);

            Console.WriteLine("Removing first element.");
            Console.WriteLine(q.Dequeue());

            Console.WriteLine("Size of stack: " + q.Count);
            Console.WriteLine("Peeking first element in queue.");
            Console.WriteLine(q.Peek());
            Console.WriteLine("Size of queue: " + q.Count);
            Console.WriteLine("Clearing the queue.");
            q.Clear();
            Console.WriteLine("Size of queue: " + q.Count);
        }

        private static void ExampleofList()
        {
            List<student> lst = new List<student>();
            lst.Add(new student(2, "John"));
            lst.Add(new student(1, "Doe"));
            lst.Add(new student(3, "Lily"));

            foreach (var stu in lst)
            {
                Console.WriteLine($"Student id {stu.id} and student name is {stu.name}");
            }

            var sortedList = lst.OrderBy(x => x.id).ToList();
            foreach (var stu in sortedList)
            {
                Console.WriteLine($"Student id {stu.id} and student name is {stu.name}");
            }

            var sortedList2 = lst.OrderBy(x => x.name).ToList();
            foreach (var stu in sortedList2)
            {
                Console.WriteLine($"Student id {stu.id} and student name is {stu.name}");
            }


            List<int> lsttemp = new List<int>();
            lsttemp.Add(1);
            lsttemp.AddRange(new List<int>() { 1, 2, 4 });
            lsttemp.Remove(1);
            Console.WriteLine(lsttemp.Count);
            lsttemp.Append(34);
            foreach (int i in lsttemp)
            {
                Console.WriteLine(i);
            }
        }

        private static void ExampleofStack()
        {
            Stack<int> stk = new Stack<int>();
            stk.Push(1);
            stk.Push(2);
            stk.Push(3);
            Console.WriteLine("Popping last add element");
            Console.WriteLine(stk.Pop());
            Console.WriteLine("Size of stack: " + stk.Count);
            stk.Clear();
            Console.WriteLine("Size of stack: " + stk.Count);
        }
    }
}
