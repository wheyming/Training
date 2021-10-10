using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConceptExamples
{
    public class parent
    {
        public int i = 10; //inherited
        private int j = 20; //no child class can inherit private variable or method.
        protected int k = 30;
        internal int o = 40;

        public void getParentvariables()
        {
            Console.WriteLine("In parent class");
            Console.WriteLine("Value of i " + i);
            Console.WriteLine("Value of j " + j);
            Console.WriteLine("Value of k " + k);
            Console.WriteLine("Value of o " + o);
        }

        private void privatemethod()
        {
            Console.WriteLine("In private method");
        }
        internal void internalmethod()
        {
            Console.WriteLine("In internal method");
        }
        protected void protectedmethod()
        {
            Console.WriteLine("In protected method");
        }
        public void publicmethod()
        {
            Console.WriteLine("In public method");
        }
    }

    public class child : parent
    {
        public int l = 50;
        private int m = 60;
        
        
        public void getChildvariables()
        {
            Console.WriteLine("In child class");
            Console.WriteLine("Value of l " + l);
            Console.WriteLine("Value of m " + m);
            k = 100;
            Console.WriteLine("Value of k " + k);
        }
    }

    public class sisterclass : parent
    {
        public void printMethodSis()
        {

        }
    }

    public class grandchild : child
    {
        public void printVariables()
        {
            Console.WriteLine("In GrandChild class");
            //Child class methods
            getChildvariables();

            //Parent Class methods
            publicmethod();
            internalmethod();
            protectedmethod();

        }

    }

    class Program1
    {
        static void Main(string[] args)
        {
            child c = new child();
            c.getParentvariables(); // k = 30
            c.getChildvariables(); // k = 100
            c.getParentvariables(); // k = 100

            Console.ReadKey();

            grandchild gc = new grandchild();
            gc.getChildvariables();
        }
    }
}
