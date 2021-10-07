using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Week5WednesdayDemonstration
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task_Declaration_Examples()
            //Task_Run_Example().Wait();
            //Task_WaitAll_Example();
            //Task_with_Function();
            //Exception_in_Task();
            //Exception_Handling_in_multipleTask();

            Task_WhenAny_Example();

            Console.ReadLine();
        }

        private static async void Task_WhenAny_Example()
        {
            Random rand = new Random();


            var tasks = Enumerable.Range(1, 5).Select(n => Task.Run(() =>
            {
                Console.WriteLine($"In Task {n}");
                Thread.Sleep(rand.Next(1000, 10000));
                return n;
            }));

            var temp = Task.WhenAny(tasks.ToArray());

            var completedTask = await temp;
            Console.WriteLine("The completed task id is " + await completedTask);

            await Task.WhenAll(tasks.ToArray());
            Console.WriteLine("All tasks completed");
        }

        private static void Exception_Handling_in_multipleTask()
        {
            var tasks = new List<Task<int>>();
            Func<object, int> func = (obj) =>
            {
                int i = (int)obj;

                if(i == 5)
                {
                    throw new InvalidOperationException();
                }

                if(i == 4)
                {
                    throw new ArgumentNullException();
                }

                if(i == 3)
                {
                    throw new NullReferenceException();
                }

                //if ( i > 2 && i < 5)
                //{
                //    throw new InvalidOperationException();
                //}
                Console.WriteLine($"Task Id: {Task.CurrentId}");
                Console.WriteLine($"Thread Id for this task: {Thread.CurrentThread.ManagedThreadId}");
                Console.WriteLine($"Task executed with value {i}");

                return 100 * i;
            };

            for(int i = 0; i < 10; i++)
            {
                tasks.Add(Task<int>.Factory.StartNew(func, i));
            }

            try
            {
                Task.WaitAll(tasks.ToArray());
                Console.WriteLine("In try block completed running all task");
            }
            catch(AggregateException ex)
            {
                Console.WriteLine("Exception raised as expected");
                for(int j = 0; j < ex.InnerExceptions.Count; j++)
                {
                    Console.WriteLine("Inner exception caught" + ex.InnerExceptions[j]);
                }
            }
        }

        private static void Exception_in_Task()
        {
            var task1 = Task.Run(() =>
            {
                throw new InvalidOperationException();
            });

            try
            {
                task1.Wait();
            }
            catch (AggregateException ex)
            {
                Console.WriteLine("This is expected.");
                Console.WriteLine("Exeption raised is: " + ex.InnerException);
            }


        }

        private static void Task_with_Function()
        {
            Func<object, int> func = (obj) =>
            {
                Console.WriteLine($"In task with function with parameter {obj}");

                return ((int)obj) * 100;
            };

            var result = Task<int>.Run(() =>
            {
                return func(100);
            });
            Console.WriteLine("Return value of result is " + result.Result);
        }

        private static void Task_WaitAll_Example()
        {
            var tasks = new List<Task>();

            Action<object> action = dosomething;
            for (int i = 0; i < 10; i++)
            {
                tasks.Add(Task.Factory.StartNew(action, i));
            }

            Task.WaitAll(tasks.ToArray());
        }

        public static async Task Task_Run_Example()
        {
            Console.WriteLine("In Task_Run_Example method");

            await Task.Run(() =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    Console.WriteLine("In task.run");
                    Thread.Sleep(1000);
                }
            });

            Console.WriteLine("Going out of Task_Run_Example method");
        }

        public static void Task_Declaration_Examples()
        {
            Action<object> action = dosomething;
            Action<object> action_1 = dosomething_1;

            // First way to declare and start a task
            Task t1 = new Task(action, "apple");
            t1.Start();

            Task t2 = new Task(action_1, "ball");
            t2.Start();

            // Second way to declare and start a task
            Task t3 = Task.Factory.StartNew(action, "cat");

            // Third way to declare a task.
            Task t4 = Task.Run(() =>
            {
                Console.WriteLine($"Task Id: {Task.CurrentId}");
                Console.WriteLine($"Thread Id for this task: {Thread.CurrentThread.ManagedThreadId}");
                Console.WriteLine($"Thread Background value: {Thread.CurrentThread.IsBackground}");
                Console.WriteLine($"Task executed with value ");
            });

            Task t5 = new Task(action_1, "Eagle");
            t5.RunSynchronously();

            t1.Wait();
            t2.Wait();
            Console.ReadLine();
        }

        public static void dosomething(object somevalue)
        {
            Console.WriteLine($"Task Id: {Task.CurrentId}");
            Console.WriteLine($"Thread Id for this task: {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"Task executed with value {somevalue}");
        }

        public static void dosomething_1(object somevalue)
        {
            Thread.Sleep(2000);
            Console.WriteLine($"Task Id: {Task.CurrentId}");
            Console.WriteLine($"Thread Id for this task: {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"Task executed with value {somevalue}");

        }
    }
}
