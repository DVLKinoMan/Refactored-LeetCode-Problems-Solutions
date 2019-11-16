using System;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Partition to K Equal Sum Subsets (Not Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static bool CanPartitionKSubsets(int[] nums, int k)
        {
            if (k > nums.Length)
                return false;
            int sum = nums.Sum();
            if (sum % k != 0)
                return false;
            Array.Sort(nums);
            return dfs(nums, 0, nums.Length - 1, new bool[nums.Length], sum / k, k);

            bool dfs(int[] A, int currSum, int st, bool[] visited, int target, int round)
            {
                if (round == 0)
                    return true;
                if (currSum == target && dfs(A, 0, A.Length - 1, visited, target, round - 1))
                    return true;
                for (int i = st; i >= 0; --i)
                {
                    if (!visited[i] && currSum + A[i] <= target)
                    {
                        visited[i] = true;
                        if (dfs(A, currSum + A[i], i - 1, visited, target, round))
                            return true;
                        visited[i] = false;
                    }
                }

                return false;
            }
        }
    }
}
