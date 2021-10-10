using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        int a;
        int b;
        const int c = 5; // cannot be assigned again.
        readonly int d = 5; // can only be reassigned once.

        //default constructor, has the class name and no return type. 
        
        
        public int e { get; set; }
        public void printe()
        {
            Console.WriteLine(e);
        }
        
        
        
        public Class1()
        {
            Console.WriteLine("Creating instance of Class1 using default constructor");
        }
        //parameterised constructor, has the class name and return type. 
        public Class1(int param1, int param2)
        {
            Console.WriteLine("Creating instance of Class1 using parameterised constructor.");
            a = param1;
            b = param2;
        }

        public void setA(int a)
        {
            this.a = a;
        }

        public void setB(int b)
        {
            this.b = b;
        }

        public int add()
        {
            return a + b;
        }

        public void printall(int i, int k, int j= 10)
        {
            Console.WriteLine(i + k + j);
        }

        internal void print()
        {
            privateprint();
            System.Console.WriteLine("This is internal");
        }
        public void privateprint()
        {
            var temp = Environment.StackTrace;
            System.Console.WriteLine("Do something");
        }
    }
}
