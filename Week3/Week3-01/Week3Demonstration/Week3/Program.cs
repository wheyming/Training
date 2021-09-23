using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    class Program
    {
        static void Main(string[] args)
        {
            IndexerExample1 indexerExample1 = new IndexerExample1();
            indexerExample1[10] = 12;
            Console.WriteLine("Print 0th index" + indexerExample1[0]);
        }
    }


    class IndexerExample
    {

    }

    class IndexerExample1
    {
        private int[] arr = new int[10];
        private string[] starr = new string[10];
        public void setarr(int[] arr1)
        {
            arr = arr1;
        }
        public int[] getarr()
        {
            return arr;
        }

        public int this[int i]
        {
            get
            {
                return arr[i];
            }
            set
            {
                arr[i] = value;
            }
        }
    }
}
