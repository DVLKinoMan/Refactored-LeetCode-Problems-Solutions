using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        public static IList<IList<int>> FindSubsequences(int[] nums)
        {
            IList<IList<int>> res = new List<IList<int>>();
            Array.Sort(nums);

            void Dfs(List<int> list, int currIndex)
            {

                if (currIndex == nums.Length)
                {
                    res.Add(list);
                    return;
                }

                for (int i = currIndex + 1; i < nums.Length; i++)
                {

                    Dfs(list, i);
                }
            }
        }
    }
}
