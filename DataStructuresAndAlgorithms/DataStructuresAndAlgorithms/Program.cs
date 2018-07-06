using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var ms = new MergeSort();
            var arr = new int[] { 4, 7, 14, 1, 3, 9, 17 };
            ms.Sort(arr, 0, arr.Length - 1);
            Console.Read();
        }
    }
}
