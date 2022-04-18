using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CandyGrammar
{
    internal class TupleClz
    {
        public static (int, string) TestTuple(int n, string s)
        {
            return (n, s);
        }

        public static void Test()
        {
            var t = TestTuple(1, "a");
            Console.WriteLine(t.Item1);
            Console.WriteLine(t.Item2);

            (int n, string s) = TupleClz.TestTuple(1, "abc");
            Console.WriteLine(n + s);
        }
    }
}
