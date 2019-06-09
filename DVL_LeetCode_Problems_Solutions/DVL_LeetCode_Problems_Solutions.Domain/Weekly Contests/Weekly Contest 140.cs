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

        public static TreeNode SufficientSubset(TreeNode root, int limit)
        {
            SufficientSubsetHelper(ref root, null, true, 0, limit);

            return root;
        }

        private static int SufficientSubsetHelper(ref TreeNode node, TreeNode prevNode, bool prevNodeWasLeft, int prevSum, int limit)
        {
            if (node == null)
                return 0;

            int leftSum = SufficientSubsetHelper(ref node.left, node, true, prevSum + node.val, limit);
            int rightSum = SufficientSubsetHelper(ref node.right, node, false, prevSum + node.val, limit);
            if (leftSum + prevSum + node.val < limit && rightSum + prevSum + node.val < limit)
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

            return leftSum + rightSum + node.val;
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
