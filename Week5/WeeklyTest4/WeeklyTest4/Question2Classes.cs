using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyTest4
{
    public interface addinterface<T>
    {
        T add(T var1, T var2);
    }
    public class Q2Class1 : addinterface<int>
    {
        int var1;
        int var2;
        public int add(int v1, int v2)
        {
            var1 = v1;
            var2 = v2;
            return var1 + var2;
        }
    }
    public class Q2Class2 : addinterface<string>
    {
        string var1;
        string var2;
        public string add(string v1, string v2)
        {
            var1 = v1;
            var2 = v2;
            return var1 + var2;
        }
    }
    public class Q2Class3 : addinterface<List<string>>
    {
        public List<string> var1 = new List<string> { "a", "c", "e", "g" };
        public List<string> var2 = new List<string> { "b", "d", "f", "h" };
        List<string> var3 = new List<string> { "0", "0", "0", "0" };
        public List<string> add(List<string> v1, List<string> v2)
        {
            for (int i = 0; i < v1.Count; i++ )
            {
                var3[i] = var1[i] + var2[i];
            }
            foreach (string str in var3)
            {
                Console.WriteLine(str);
            }
            return var3;
        }
    }
    //public class Q2Class4 : addinterface<class>
    //{
    //    class var1
    //    {

    //    }
    //    class var2
    //    {

    //    }
    //    public string add(class v1, class v2)
    //    {

    //    }
    //}

    public class customclassimplementation : addinterface<customclass>
    {
        public customclass add(customclass a, customclass b)
            {
            var customclass1 = new customclass();

            customclass1.someProperty.AddRange(a.someProperty);
            customclass1.someProperty.AddRange(b.someProperty);

            return customclass1;
        }
    }

    public class customclass
    {
        public List<int> someProperty { get; set; }
    }
}
