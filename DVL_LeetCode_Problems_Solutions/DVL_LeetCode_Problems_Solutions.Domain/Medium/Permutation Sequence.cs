using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        ///// <summary>
        ///// Permutation Sequence (My Solution - right but not fast)
        ///// </summary>
        ///// <param name="n"></param>
        ///// <param name="k"></param>
        ///// <returns></returns>
        //public static string GetPermutation(int n, int k)
        //{
        //    var list = Enumerable.Range(1, n).Select(i => i.ToString()).ToList();
        //    StringBuilder str = new StringBuilder();
        //    int count = 0;
        //    GetPermutationHelper(str, list, ref count, k);
        //    return str.ToString();
        //}

        //public static void GetPermutationHelper(StringBuilder str, List<string> list, ref int count, int k)
        //{
        //    if (list.Count == 0)
        //    {
        //        count++;
        //        return;
        //    }

        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        var ch = list[i];
        //        str.Append(ch);
        //        list.RemoveAt(i);
        //        GetPermutationHelper(str, list, ref count, k);
        //        if (count == k)
        //            return;
        //        list.Insert(i, ch);
        //        str.Remove(str.Length - 1, 1);
        //    }
        //}

        /// <summary>
        /// Permutation Sequence (Better Solution)
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static string GetPermutation(int n, int k)
        {
            int[] factorial = new int[n];
            factorial[0] = 1;
            int temp = 1;
            for (int i = 1; i < n; i++)
            {
                temp *= i;
                factorial[i] = temp;
            }

            List<int> numbers = new List<int>();
            for (int i = 1; i <= n; i++)
                numbers.Add(i);

            k--;

            StringBuilder str = new StringBuilder();
            for (int i = 1; i <= n; i++)
            {
                int index = k / factorial[n - i];
                str.Append(numbers[index]);
                numbers.RemoveAt(index);
                k -= index * factorial[n - i];
            }

            return str.ToString();
        }
    }
}
