using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
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
                if (x == y)
                    return 0;

                int len = Math.Min(x.Length, y.Length);
                for(int i=0; i<len; i++)
                    if (x[i] != y[i])
                        return x.CompareTo(y);

                if (x.Length == len)
                {
                    if (y.Length > len)
                    {
                        if (y[len] == '0')
                            return 1;
                        if (y[len - 1] < y[len])
                            return -1;
                        return 1;
                    }
                }

                if (y.Length == len)
                {
                    if (x.Length > len)
                    {
                        if (x[len] == '0')
                            return -1;
                        if (x[len - 1] < x[len])
                            return 1;
                        return -1;
                    }
                }

                return x.CompareTo(y);
            }
        }
    }
}
