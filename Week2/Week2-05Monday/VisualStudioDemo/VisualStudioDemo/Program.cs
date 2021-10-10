using ClassLibrary1;
using System;
using System.Collections.Generic;

namespace VisualStudioDemo
{

    class Parent
    {
        //"ctor" + tab will create constructor automatically
        public Parent()
        {
            Console.WriteLine("In constructor of parent");
        }
        static Parent()
        {
            Console.WriteLine("In static constructor of parent");
        }
    }

    class Child: Parent
    {
        static Child()
        {
            Console.WriteLine("In static constructor of child");
        }

        public Child()
        {
            Console.WriteLine("In constructor of child");
        }
    }

    class Grandchild: Child
    {
        public Grandchild()
        {
            Console.WriteLine("In constructor of grandchild");
        }
    }

    //class egstatic
    //{
    //    public static void eggstatic()
    //    {
    //        Console.WriteLine("funn");
    //    }
    //}

    class indexerExample
    {
        private int[] sampletype = new int[10];

        //private List<int> samplelist = new List<int>();

        public int this [int i]
        {
            get
            {
                return sampletype[i];
            }
            set
            {
                sampletype[i] = value;
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Parent p = new Parent();
            //Child c = new Child();
            //Grandchild gc = new Grandchild();

            //egstatic.eggstatic();


            // indexer example
            indexerExample id = new indexerExample();
            id[0] = 1;
            id[1] = 2;
            id[2] = 3;
            id[3] = 4;
            id[4] = 5;

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(id[i]);
            }            



            Console.WriteLine("Example of console application");
            Class1 class1 = new Class1(3, 4); //search for a constructor with the same parameters and create an instance of it. 
       
            Class1 class1instance = new Class1(); //call the default constructor
            class1instance.setA(1);
            class1instance.setB(9);

            class1instance.printall(4, 5, 6);
            class1instance.printall(4, 7);

            Class1 Eclass1instance = new Class1 { e = 5 };
            Eclass1instance.printe();

            int res = class1.add();

            if (res <= 7)
            {
                Console.WriteLine("result is less than 7");
            }
            else
            {
                Console.WriteLine("result more than 7");
            }
            res = res * 2;
            res = res + 1;


            Console.ReadLine();

        }
    }
}
