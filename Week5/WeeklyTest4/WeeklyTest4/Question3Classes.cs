using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyTest4
{
    public interface Q3interface<T, A, B>
    {
        bool validateMethod(T varT);

        B inspectMethod(T varT, A varA);
    }

    public class Question3Classes<T, A, B> : Q3interface<T, A, B>
    {
        public bool validateMethod(T varT)
        {
            Console.WriteLine(Convert.ToString(varT));
            return true;
        }

        public B inspectMethod(T varT, A varA)
        {
            Console.WriteLine(Convert.ToString(varT));
            object obj = new object();
            obj = 1;
            return (B)obj; // error during runtime.
        }
    }
}
