using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMSession
{
    public class Product
    {
        public string Id { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
    }
    public class MMProduct : Product
    {
        public string Photo { get; set; }
    }

    public interface IOperation<T>
    {
        T Operation(T var1);
    }

    public class Operation : IOperation<Product>
    {
        Product IOperation<Product>.Operation(Product var1)
        {
            Console.WriteLine("Product Id: " + var1.Id);
            Console.WriteLine("Product Price: " + var1.Price);
            Console.WriteLine("Product Descr: " + var1.Description);
            return var1;
        }
    }

    public class Operation1<T> : IOperation<T> where T : Product
    {
        public T Operation(T var1)
        {
            Console.WriteLine("Product Id: " + var1.Id);
            Console.WriteLine("Product Price: " + var1.Price);
            Console.WriteLine("Product Descr: " + var1.Description);
            //Console.WriteLine("Product Photo: " + var1.Photo);
            return var1;
        }
    }



    public interface IAddition<T>
    {
        T Add(T var1, T var2);
    }
    public class GenClass : IAddition<int>
    {
        int var1;
        int var2;
        public int Add(int v1, int v2)
        {
            var1 = v1;
            var2 = v2;
            return var1 + var2;
        }
    }
    public class GenClass1 : IAddition<double>
    {
        double var1;
        double var2;
        public double Add(double v1, double v2)
        {
            var1 = v1;
            var2 = v2;
            return var1 + var2;
        }
    }

    //public class GenClass<T>
    //{
    //    T var1;
    //    T var2;
    //    List<T> var3 = new List<T>();
    //    public T Add(T v1, T v2)
    //    {
    //        var1 = v1;
    //        var2 = v2;
    //        var3.Add(var1);
    //        var3.Add(var2);

    //        int count = var3.Where((x) => 10 > 20).Count();
    //        return var1;
    //    }
    //}

    public class GenClass<T>
    {
        T var1;
        T var2;
        //List<T> var3 = new List<T>();
        public string Add(T v1, T v2)
        {
            var1 = v1;
            var2 = v2;
            //var3.Add(var1);
            //var3.Add(var2);
            //int count = var3.Where((x) => 10 > 20).Count();
            return var1.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GenClass<Product> genClassp = new GenClass<Product>();
            string p = genClassp.Add(new Product(), new Product());
            Console.WriteLine(p);
            GenClass<int> genClassInt = new GenClass<int>();
            //int i = genClassInt.Add(10, 20);
            //Console.WriteLine("The output of the integer Operation : " + i);
            GenClass<double> genClassDouble = new GenClass<double>();
            //double j = genClassDouble.Add(10.5, 20.8);
            //Console.WriteLine("The output of the double Operation : " + j);
            Console.ReadLine();

            //GenClass<int> genClassInt = new GenClass<int>();
            //int i = genClassInt.Add(10, 20);
            //Console.WriteLine("The output of the integer Operation : " + i);
            //GenClass<double> genClassDouble = new GenClass<double>();
            //double j = genClassDouble.Add(10.5, 20.8);
            //Console.WriteLine("The output of the double Operation : " + j);
            //Console.ReadLine();

            //IAddition<int> genClassInt = new GenClass();
            //int i = genClassInt.Add(10, 20);
            //Console.WriteLine("The output of the integer Operation : " + i);
            //IAddition<double> genClassDouble = new GenClass1();
            //double j = genClassDouble.Add(10.5, 20.8);
            //Console.WriteLine("The output of the double Operation : " + j);


            IOperation<Product> op = new Operation();
            op.Operation(new MMProduct() { Id = "da", Description = "dasdasdasd", Price = 9000, Photo = "this m" });

            Console.WriteLine("-------------------------------------------------------");

            Operation1<Product> op1 = new Operation1<Product>();
            op1.Operation(new MMProduct() { Id = "da", Description = "dasdasdasd", Price = 9000, Photo = "this m" });
            Console.ReadLine();
        }
    }
}
