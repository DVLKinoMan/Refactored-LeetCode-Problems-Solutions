using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain.Easy
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Majority Element II (Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static IList<int> MajorityElement(int[] nums) {
            var dict = new Dictionary<int,int>();
            foreach(var num in nums)
                dict[num] = dict.ContainsKey(num) ? dict[num] + 1 : 1;

            int len = nums.Length / 3;
            var list = new List<int>();
            foreach(var d in dict)
                if(d.Value > len)
                    list.Add(d.Key);
            return list;
        }
    }
}