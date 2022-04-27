using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            foreach (int i in Power(2, 8))
            {
                Console.Write($"{i} ");
            }
        }

        public static IEnumerable<int> Power(int number, int exponent)
        {
            int result = 1;

            for (int i = 0; i < exponent; i++)
            {
                result *= number;
                yield return result;
            }
        }
    }
}
