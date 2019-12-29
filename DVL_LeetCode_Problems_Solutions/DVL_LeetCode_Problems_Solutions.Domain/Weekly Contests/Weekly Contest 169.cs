using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Find N Unique Integers Sum up to Zero (Mine)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int[] SumZero(int n)
        {
            int k = 1;
            var list = new List<int>();
            int count = 0, len = n % 2 == 1 ? n - 1 : n;
            while (count != len)
            {
                list.Add(k);
                list.Add(-1*k);
                k++;
                count += 2;
            }

            if(len!=n)
                list.Add(0);

            return list.ToArray();
        }

        /// <summary>
        /// All Elements in Two Binary Search Trees  (Mine)
        /// </summary>
        /// <param name="root1"></param>
        /// <param name="root2"></param>
        /// <returns></returns>
        public static IList<int> GetAllElements(TreeNode root1, TreeNode root2)
        {
            var list = new List<int>();
            var fList = InOrder(root1).ToList();
            var sList = InOrder(root2).ToList();
            int i = 0, j = 0;
            while (i < fList.Count || j < sList.Count)
            {
                if (j >= sList.Count || (i < fList.Count && fList[i] < sList[j]))
                {
                    list.Add(fList[i]);
                    i++;
                }
                else
                {
                    list.Add(sList[j]);
                    j++;
                }
            }

            return list;

            IEnumerable<int> InOrder(TreeNode node)
            {
                if (node == null)
                    yield break;

                foreach (var n in InOrder(node.left))
                    yield return n;

                yield return node.val;

                foreach (var n in InOrder(node.right))
                    yield return n;
            }
        }

        /// <summary>
        /// Jump Game III (Mine)
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="start"></param>
        /// <returns></returns>
        public static bool CanReach(int[] arr, int start)
        {
            var visitedSet = new HashSet<int>();
            return Dfs(start);

            bool Dfs(int index)
            {
                if (visitedSet.Contains(index))
                    return false;
                if (arr[index] == 0)
                    return true;

                visitedSet.Add(index);
                if (index - arr[index] >= 0 && Dfs(index - arr[index]))
                    return true;

                if (index + arr[index] < arr.Length && Dfs(index + arr[index]))
                    return true;

                return false;
            }
        }
    }
}
