using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        ///// <summary>
        ///// Find Duplicate Subtrees (Not working, it can not find all subtree structures)
        ///// </summary>
        ///// <param name="root"></param>
        ///// <returns></returns>
        //public static IList<TreeNode> FindDuplicateSubtrees(TreeNode root)
        //{
        //    var list = new List<TreeNode>();
        //    if (root == null)
        //        return list;

        //    var set = new HashSet<int>();

        //    var allNodes = FindDuplicateSubtreesHelper2(root).ToArray();
        //    for (int i = 0; i < allNodes.Length; i++)
        //        for (int j = i + 1; j < allNodes.Length; j++)
        //            if (FindDuplicateSubtreesHelper(allNodes[i], allNodes[j]) && !set.Contains(allNodes[i].val))
        //            {
        //                list.Add(allNodes[i]);
        //                set.Add(allNodes[i].val);
        //            }

        //    return list;
        //}

        //private static bool FindDuplicateSubtreesHelper(TreeNode node1, TreeNode node2)
        //{
        //    if (node1 == null || node2 == null)
        //        return false;

        //    return node1.left == node2.left || node1.right == node2.right;
        //}

        //private static IEnumerable<TreeNode> FindDuplicateSubtreesHelper2(TreeNode node)
        //{
        //    if (node.left != null)
        //        foreach(var n in FindDuplicateSubtreesHelper2(node.left))
        //            yield return n;

        //    if (node.right != null)
        //        foreach (var n in FindDuplicateSubtreesHelper2(node.right))
        //            yield return n;

        //    yield return node;
        //}

        /// <summary>
        /// Find Duplicate Subtrees (Not mine)
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static IList<TreeNode> FindDuplicateSubtrees(TreeNode root)
        {
            var list = new List<TreeNode>();
            FindDuplicateSubtreesHelper(root, new Dictionary<string, int>(), list);
            return list;
        }

        private static string FindDuplicateSubtreesHelper(TreeNode cur, Dictionary<string,int> dic, List<TreeNode> res)
        {
            if (cur == null)
                return "#";

            string serial = cur.val + "," + FindDuplicateSubtreesHelper(cur.left, dic, res) + "," + FindDuplicateSubtreesHelper(cur.right, dic, res);
            if (dic.ContainsKey(serial) && dic[serial] == 1)
                res.Add(cur);

            if (dic.ContainsKey(serial))
                dic[serial]++;
            else dic.Add(serial, 1);

            return serial;
        }
    }
}
