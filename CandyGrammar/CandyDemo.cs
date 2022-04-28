using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LeetCode.CandyGrammar
{
    internal class CandyDemo
    {
        public static void TestArrApi()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var arr1 = arr.Skip(1);
            Console.WriteLine(string.Join(",", arr1));
            var arr2 = arr1.Take(3);
            Console.WriteLine(string.Join(",", arr2));

            int[] arr3 = arr[1 .. 4];
            Console.WriteLine(string.Join(",", arr3));
        }


        public static void YieldTest()
        {
            IEnumerable<int> numbers = Fibonacci(10);
            

            foreach (int n in from nums in numbers
                              where nums % 2 == 0
                              select nums)
            {
                Console.WriteLine(n);
            }
        }

        private static IEnumerable<int> Fibonacci(int count)
        {
            int prev = 1;
            int curr = 1;
            List<int> result = new();
            for (int i = 0; i < count; i++)
            {
                yield return prev;
                Thread.Sleep(1000);
                int temp = prev;
                prev = curr;
                curr = temp + curr;
            }
        }
    }
}
