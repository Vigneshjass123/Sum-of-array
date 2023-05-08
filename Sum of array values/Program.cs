using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_array_values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 4, 6, 8, 10 };
            int sum = 0;
            for(int i = 0;i< arr.Length;i++)
                {
                sum = sum + arr[i];
            }
            Console.WriteLine("sum of array value is= " +  sum);
        }
    }
}
