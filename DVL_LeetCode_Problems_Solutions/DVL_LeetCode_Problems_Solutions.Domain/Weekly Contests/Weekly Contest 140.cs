﻿using DVL_LeetCode_Problems_Solutions.Domain.Classes;
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
        /// Insufficient Nodes in Root to Leaf Paths (Not Mine)
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

        public static string SmallestSubsequence(string text)
        {
            var lettersIndexes=new Dictionary<char, List<int>>();
            int[] minLefts=new int[text.Length];
            int minLeft = int.MaxValue;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] < minLeft)
                    minLeft = text[i];
                minLefts[i] = minLeft;

                if (lettersIndexes.ContainsKey(text[i]))
                    lettersIndexes[text[i]].Add(i);
                else lettersIndexes.Add(text[i], new List<int> {i});
            }

            var arrOfRightIndex = new bool[text.Length];
            foreach (var letterIndexes in lettersIndexes)
            {
                int letterIndex = -1, minValue = int.MaxValue;
                foreach (var index in letterIndexes.Value)
                    if (minLefts[index] <= minValue)
                    {
                        minValue = minLefts[index];
                        letterIndex = index;
                    }

                arrOfRightIndex[letterIndex] = true;
            }

            var resString = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
                if (arrOfRightIndex[i] == true)
                    resString.Append(text[i]);

            return resString.ToString();
        }
    }
}
