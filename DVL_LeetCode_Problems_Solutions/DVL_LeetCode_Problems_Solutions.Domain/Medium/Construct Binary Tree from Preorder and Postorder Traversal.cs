using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Construct Binary Tree from Preorder and Postorder Traversal (Not Mine)
        /// </summary>
        /// <param name="pre"></param>
        /// <param name="post"></param>
        /// <returns></returns>
        public static TreeNode ConstructFromPrePost(int[] pre, int[] post)
        {
            var head = new TreeNode(pre[0]);
            var stack = new Stack<TreeNode>();
            stack.Push(head);
            for (int i = 1, j = 0; i < pre.Length; i++)
            {
                var node = new TreeNode(pre[i]);
                while (stack.Peek().val == post[j])
                {
                    stack.Pop();
                    j++;
                }

                if (stack.Peek().left == null)
                    stack.Peek().left = node;
                else stack.Peek().right = node;
                stack.Push(node);
            }

            return head;
        }
    }
}
