using System;
using System.Linq;
using System.Text;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Remove All Adjacent Duplicates In String (Mine)
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public static string RemoveDuplicates(string S)
        {
            var str = new StringBuilder(S);

            for (int i = 1; i < str.Length; i++)
            {
                int j = i;
                while (i < str.Length && str[i] == str[i - 1])
                    i++;
                if (j != i)
                    str.Remove(j - 1, i != str.Length ? i - j : i - 1 - j);
            }

            var result = str.ToString();
            if (result == S)
                return S;

            return RemoveDuplicates(result);
        }

        /// <summary>
        /// Last Stone Weight (Mine)
        /// </summary>
        /// <param name="stones"></param>
        /// <returns></returns>
        public static int LastStoneWeight(int[] stones)
        {
            var list = stones.ToList();

            while (list.Count > 1)
            {
                list.Sort();
                int f = list[list.Count - 2];
                int s = list[list.Count - 1];
                list.RemoveAt(list.Count - 2);
                list.RemoveAt(list.Count - 1);
                if (f != s)
                    list.Add(s - f);
            }

            return list.Count == 0 ? 0 : list[0];
        }

        public static int LongestStrChain(string[] words)
        {
            var dic = words.GroupBy(w => w.Length).Select(gr => new {gr.Key, list = gr.ToList()}).OrderBy(d=>d.Key).ToList();
            int result = 0;

            for (int i = 0; i < dic.Count; i++)
            {
                foreach (var word1 in dic[i].list)
                {
                    string currWord = word1;
                    int count = 0;
                    for (int j = i + 1; j < dic.Count; j++)
                    {
                        if (dic[i].Key + 1 != dic[j].Key)
                            break;

                        bool hasPredecessor = false;
                        foreach (var word2 in dic[j].list)
                            if (LongestStrChainHelper(word1, word2))
                            {
                                hasPredecessor = true;
                                break;
                            }

                        if (!hasPredecessor)
                            break;
                        //currWord=
                        count++;
                    }

                    result = Math.Max(result, count);
                }
            }

            return result;
        }

        private static bool LongestStrChainHelper(string word1, string word2)
        {
            for (int i = 0; i < word2.Length; i++)
                if (word2.Remove(i, 1) == word1)
                    return true;

            return false;
        }
        

        public static int LastStoneWeightII(int[] stones)
        {
            var list = stones.ToList();

            while (list.Count > 1)
            {
                list.Sort();
                int f = list[list.Count - 2];
                int s = list[list.Count - 1];
                list.RemoveAt(list.Count - 2);
                list.RemoveAt(list.Count - 1);
                if (f != s)
                    list.Add(s - f);
            }

            return list.Count == 0 ? 0 : list[0];
        }
    }
}
