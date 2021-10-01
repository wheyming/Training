using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4ThursdayDemonstration
{
    class Program
    {
        static void Main(string[] args)
        {
            //GenericAtMethodLevel.applyingGenericAtMethodLevel();
            //GenericAtClassLevel.applyingGenericAtClassLevel();
            //GenericAtFunctionInsideClass.applyingGenericAtfunctionInsideaClass();

        }


 
}

    public interface IMyGenericInterface<T>
    {
        void doSomething(T a, T b);

        T dosomethingelse(T a, T b);
    }

    //First way to create a class of generic interface
    public class FirstMyGenericClass : IMyGenericInterface<int>
    {
        public void doSomething(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int dosomethingelse(int a, int b)
        {
            throw new NotImplementedException();
        }

        public void mygenericclass()
        {
            FirstMyGenericClass mygenericclass = new FirstMyGenericClass();
            mygenericclass.doSomething(1, 1);
        }
    }
    
    //Second way to create a class of generic interface
    public class SecondMyGenericClass<T> : IMyGenericInterface<T>
    {
        public void doSomething(T a, T b)
        {
            throw new NotImplementedException();
        }

        public T dosomethingelse(T a, T b)
        {
            throw new NotImplementedException();
        }

        public void creategenerictype()
        {
            SecondMyGenericClass<int> secondMyGenericClass = new SecondMyGenericClass<int>();
            secondMyGenericClass.doSomething(1, 2);

            SecondMyGenericClass<float> secondMyGenericClassbool = new SecondMyGenericClass<float>();
            secondMyGenericClassbool.doSomething(1.4f, 2.6f);
        }
    }

    public class GenericWhereUsage
    {
        public class Parent
        {

        }
        public class Child: Parent
        {

        }

        public class something
        {

        }

        public class SampleClass<A>
        {
            A[] arrObj2 = new A[5];
            int count = 0;

            public void Add(A item) // add
            {
                if (count + 1 < 5)
                {
                    arrObj2[count] = item;
                }
                count++;
            }

            public A this[int index] // indexer
            {
                get { return arrObj2[index]; }
                set { arrObj2[index] = value; }
            }

        }

        public class Device2<A> where A: Parent
        {
            public A name { get; set; }
            public A category { get; set; }
        }

        public static void applyingGenericwhere()
        {
            Device2<Parent> parentObj = new Device2<Parent>();
            // Device2<something> somethingObj = new Device2<something>();
            // Device2<string> stringObj = new Device2<string>();
        }
    }

    public class GenericAtFunctionInsideClass
    {
        public static void applyingGenericAtfunctionInsideaClass()
        {
            GenericAtClassLevel.SampleClass<float> floatclass = new GenericAtClassLevel.SampleClass<float>();
            floatclass.Add(3.4f);
            floatclass.Add(1.4f);
            floatclass.Add(2.4f);
            floatclass.Add(4.4f);
            floatclass.Add(5.4f);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(floatclass[i]);
            }

            GenericAtClassLevel.SampleClass<int> intclass = new GenericAtClassLevel.SampleClass<int>();
            intclass.Add(3);
            intclass.Add(1);
            intclass.Add(2);
            intclass.Add(4);
            intclass.Add(5);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(intclass[i]);
            }

            GenericAtClassLevel.SampleClass<bool> boolclass = new GenericAtClassLevel.SampleClass<bool>();
            boolclass.Add(true);
            boolclass.Add(true);
            boolclass.Add(false);
            boolclass.Add(false);
            boolclass.Add(true);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(floatclass[i]);
            }
        }
    }

    public class GenericAtClassLevel
    {
        public class SampleClass<T>
        {
            T[] arrObj = new T[5];
            int count = 0;

            public void Add(T item) // add
            {
                if(count + 1 < 5)
                {
                    arrObj[count] = item;
                }
                count++;
            }

            public T this[int index] // indexer
            {
                get { return arrObj[index]; }
                set { arrObj[index] = value; }
            }

        }

        public class Device<T>
        {
            public T name { get; set; }
            public T category { get; set; }
        }    

        public static void applyingGenericAtClassLevel()
        {
            Device<int> intObj = new Device<int>();
            Device<float> floatObj = new Device<float>();
            Device<string> stringObj = new Device<string>();

            intObj.name = 1;
            intObj.category = 2;

            floatObj.name = 5.1f;
            floatObj.category = 3.4f;

            stringObj.name = "Somename";
            stringObj.category = "Somecategory";

            Console.WriteLine($"The name is {intObj.name} in {intObj.category}.");
            Console.WriteLine($"The name is {floatObj.name} in {floatObj.category}.");
            Console.WriteLine($"The name is {stringObj.name} in {stringObj.category}.");
        }

    }

    public class GenericAtMethodLevel
    {        
        public static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public static void applyingGenericAtMethodLevel()
        {
            int a = 3;
            int b = 4;
            Console.WriteLine("Before a: " + a);
            Console.WriteLine("Before b: " + b);
            swap<int>(ref a, ref b);
            Console.WriteLine("After a: " + a);
            Console.WriteLine("After b: " + b);


            float c = 1.5f;
            float d = 5.5f;
            Console.WriteLine("Before c: " + c);
            Console.WriteLine("Before d: " + d);
            swap<float>(ref c, ref d);
            Console.WriteLine("After c: " + c);
            Console.WriteLine("After d: " + d);


            string s1 = "something";
            string s2 = "someone";
            Console.WriteLine("Before s1: " + s1);
            Console.WriteLine("Before s2: " + s2);
            swap<string>(ref s1, ref s2);
            Console.WriteLine("After s1: " + s1);
            Console.WriteLine("After s2: " + s2);
        }
    }
}
