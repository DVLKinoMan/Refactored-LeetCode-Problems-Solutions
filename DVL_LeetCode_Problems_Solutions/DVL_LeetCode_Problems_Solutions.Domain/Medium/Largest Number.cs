using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Largest Number (Not mine, but almost)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static string LargestNumber(int[] nums)
        {
            if (nums.Length == 0)
                return "";

            var list = new List<string>();
            foreach (var num in nums)
                list.Add(num.ToString());

            var comp = new Comparer();
            var res = string.Join("", list.OrderByDescending(n => n, comp).SkipWhile(n=>n=="0"));
            return string.IsNullOrEmpty(res) ? "0" : res;
        }

        public class Comparer : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                string str1 = x + y;
                string str2 = y + x;

                return str1.CompareTo(str2);
            }
        }
    }
}
