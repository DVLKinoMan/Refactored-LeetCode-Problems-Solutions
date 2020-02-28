using System.Collections.Generic;
using System.Linq;
using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// All Nodes Distance K in Binary Tree (Not Working)
        /// </summary>
        /// <param name="root"></param>
        /// <param name="target"></param>
        /// <param name="K"></param>
        /// <returns></returns>
        public static IList<int> DistanceK(TreeNode root, TreeNode target, int K) {
            var dict = new Dictionary<int, List<int>>();
            var result = new List<int>();

            if (K == 0)
            {
                result.Add(target.val);
                return result;
            }
            
            Build(null, root);

            if (dict.Count == 0)
                return result;

            Dfs(target.val);

            return result.Where(r=>r != target.val)
                         .Distinct()
                         .ToList();

            void AddOrUpdate(int key, int val)
            {
                if (dict.ContainsKey(key))
                    dict[key].Add(val);
                else dict[key] = new List<int>() {val};
            }

            void Build(TreeNode parent, TreeNode child)
            {
                if (parent != null)
                {
                    AddOrUpdate(parent.val, child.val);
                    AddOrUpdate(child.val, parent.val);
                }

                if (child?.left != null)
                    Build(child, child.left);
                if (child?.right != null)
                    Build(child, child.right);
            }

            void Dfs(int currVal, int height = 0)
            {
                if (height == K - 1)
                {
                    result.AddRange(dict[currVal]);
                    return;
                }

                foreach (var val in dict[currVal])
                    Dfs(val, height + 1);
            }
        }
    }
}