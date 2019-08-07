using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Most Frequent Subtree Sum (Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int[] FindFrequentTreeSum(TreeNode root)
        {
            if (root == null)
                return new int[0];

            var occuringFrequency = new Dictionary<int, int>();
            FindFrequentTreeSumHelper(root, occuringFrequency);
            int max = occuringFrequency.Max(k => k.Value);

            var list = new List<int>();
            foreach (var occ in occuringFrequency.Where(k => k.Value == max))
                list.Add(occ.Key);

            return list.ToArray();
        }

        private static int FindFrequentTreeSumHelper(TreeNode root, Dictionary<int,int> dic)
        {
            if (root == null)
                return 0;

            int sum = FindFrequentTreeSumHelper(root.left, dic) + FindFrequentTreeSumHelper(root.right, dic) + root.val;
            if (dic.ContainsKey(sum))
                dic[sum]++;
            else dic.Add(sum, 1);

            return sum;
        }
    }
}
