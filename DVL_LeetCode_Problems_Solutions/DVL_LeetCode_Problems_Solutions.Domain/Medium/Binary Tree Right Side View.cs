using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Binary Tree Right Side View (Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static IList<int> RightSideView(TreeNode root)
        {
            //My Version:
            //if(root == null)
            //    return new List<int>();
            //var res = new List<int>() {root.val};
            //var list = new List<TreeNode>() {root};
            //while (list.Count != 0)
            //{
            //    var newList = new List<TreeNode>();
            //    bool wasFoundLast = false;
            //    foreach (var node in list)
            //    {
            //        var n = node.right ?? node.left;
            //        if (!wasFoundLast && n != null)
            //        {
            //            res.Add(n.val);
            //            wasFoundLast = true;
            //        }
            //        if(node.right!=null)
            //            newList.Add(node.right);
            //        if(node.left!=null)
            //            newList.Add(node.left);
            //    }

            //    list = newList;
            //}

            //return res;

            //My implementation (not my solution):
            var result = new List<int>();
            if (root != null)
            {
                result.Add(root.val);
                Rec(root, 1, result);
            }
            return result;

            void Rec(TreeNode node, int level, List<int> res)
            {
                if(node == null)
                    return;
                if (res.Count < level)
                    res.Add(node.val);
                Rec(node.right, level + 1, res);
                Rec(node.left, level + 1, res);
            }
        }
    }
}
