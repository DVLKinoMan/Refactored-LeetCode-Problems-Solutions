using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain.Weekly_Contests
{
    partial class ProblemSolver
    {
        public bool UniqueOccurrences(int[] arr)
        {
            var dic = new Dictionary<int, int>();

            foreach (var num in arr)
            {
                if (dic.ContainsKey(num))
                    dic[num]++;
                else dic.Add(num, 1);
            }

            return dic.Values.Distinct().Count() == dic.Values.Count;
        }
    }
}
