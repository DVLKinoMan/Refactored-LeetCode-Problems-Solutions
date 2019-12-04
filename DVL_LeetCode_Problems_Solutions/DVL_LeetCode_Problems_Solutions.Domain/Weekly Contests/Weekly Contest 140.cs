using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Occurrences After Bigram  (Mine)
        /// </summary>
        /// <param name="text"></param>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static string[] FindOcurrences(string text, string first, string second)
        {
            var result = new List<string>();
            var arr = text.Split(' ');
            for (int i = 2; i < arr.Length; i++)
                if (arr[i - 2] == first && arr[i - 1] == second)
                    result.Add(arr[i]);

            return result.ToArray();
        }

        /// <summary>
        /// Letter Tile Possibilities (Mine)
        /// </summary>
        /// <param name="tiles"></param>
        /// <returns></returns>
        public static int NumTilePossibilities(string tiles)
        {
            var set = new HashSet<string>();
            var list = tiles.ToList();

            for (int i = 1; i <= tiles.Length; i++)
                NumTilePossibilitiesHelper(new StringBuilder(), set, list, i);

            return set.Count;
        }

        private static void NumTilePossibilitiesHelper(StringBuilder currStr, HashSet<string> set, List<char> tiles, int length)
        {
            if (currStr.Length == length)
            {
                set.Add(currStr.ToString());
                return;
            }

            int len = currStr.Length;
            for (int i = 0; i < tiles.Count; i++)
            {
                char ch = tiles[i];
                currStr.Append(ch);
                tiles.RemoveAt(i);
                NumTilePossibilitiesHelper(currStr, set, tiles, length);
                tiles.Insert(i, ch);
                currStr.Remove(len - 1, currStr.Length - len);
            }
        }

        /// <summary>
        /// Insufficient Node in Root to Leaf Paths (Not Mine)
        /// </summary>
        /// <param name="root"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public static TreeNode SufficientSubset(TreeNode root, int limit)
        {
            if (root.left == root.right)
                return root.val < limit ? null : root;
            if (root.left != null)
                root.left = SufficientSubset(root.left, limit - root.val);
            if (root.right != null)
                root.right = SufficientSubset(root.right, limit - root.val);
            return root.left == root.right ? null : root;
        }

        /// <summary>
        /// do not works
        /// </summary>
        /// <param name="node"></param>
        /// <param name="prevNode"></param>
        /// <param name="prevNodeWasLeft"></param>
        /// <param name="prevSum"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        private static int SufficientSubsetHelper(ref TreeNode node, TreeNode prevNode, bool prevNodeWasLeft,
            int prevSum, int limit)
        {
            if (node.left == null && node.right == null)
            {
                int val = node.val;
                if (prevSum + node.val < limit)
                {
                    if (prevNode != null)
                    {
                        if (prevNodeWasLeft)
                            prevNode.left = null;
                        else prevNode.right = null;
                    }
                    else node = null;
                }
                return val;
            }

            int? leftSum = node.left != null
                ? (int?) SufficientSubsetHelper(ref node.left, node, true, prevSum + node.val, limit)
                : null;
            int? rightSum = node.right != null
                ? (int?) SufficientSubsetHelper(ref node.right, node, false, prevSum + node.val, limit)
                : null;
            bool leftLessThanLimit = leftSum == null ? true : leftSum + prevSum + node.val < limit;
            bool rightLessThanLimit = rightSum == null ? true : rightSum + prevSum + node.val < limit;
            if (leftLessThanLimit && rightLessThanLimit)
            {
                if (prevNode != null)
                {
                    if (prevNodeWasLeft)
                        prevNode.left = null;
                    else prevNode.right = null;
                }
                else node = null;

                return 0;
            }

            return (leftSum ?? 0) + (rightSum ?? 0) + node.val;
        }

        /// <summary>
        /// Smallest Subsequence of Distinct Characters (Not Mine)
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string SmallestSubsequence(string text)
        {
            var stack = new Stack<int>();
            int[] last = new int[26];
            bool[] seen = new bool[26];
            for (int i = 0; i < text.Length; ++i)
                last[text[i] - 'a'] = i;
            for (int i = 0; i < text.Length; ++i)
            {
                int c = text[i] - 'a';
                if (seen[c]) continue;
                while (stack.Count != 0 && stack.Peek() > c && i < last[stack.Peek()])
                    seen[stack.Pop()] = false;

                stack.Push(c);
                seen[c] = true;
            }

            return string.Join("", stack.Select(c => (char) (c + 'a')).Reverse());
        }
    }
}
