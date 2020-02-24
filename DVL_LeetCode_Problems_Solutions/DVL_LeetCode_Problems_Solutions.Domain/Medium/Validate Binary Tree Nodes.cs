using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Validate Binary Tree Nodes (Mine)
        /// </summary>
        /// <param name="n"></param>
        /// <param name="leftChild"></param>
        /// <param name="rightChild"></param>
        /// <returns></returns>
        public static bool ValidateBinaryTreeNodes(int n, int[] leftChild, int[] rightChild)
        {
            var visitedNodes = new HashSet<int>() {0};
            for (int i = 0; i < n; i++)
            {
                if (!visitedNodes.Contains(i))
                    return false;

                if (leftChild[i] != -1 && !visitedNodes.Add(leftChild[i]))
                    return false;
                if (rightChild[i] != -1 && !visitedNodes.Add(rightChild[i]))
                    return false;
            }

            return true;
        }
    }
}