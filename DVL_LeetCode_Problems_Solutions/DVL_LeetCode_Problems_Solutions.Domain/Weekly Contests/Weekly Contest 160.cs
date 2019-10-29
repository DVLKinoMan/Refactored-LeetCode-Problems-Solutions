using System;
using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    public interface CustomFunction
    {
        int f(int x, int y);
    };

    partial class ProblemSolver
    {
        /// <summary>
        /// Find Positive Integer Solution for a Given Equation (Mine)
        /// </summary>
        /// <param name="customfunction"></param>
        /// <param name="z"></param>
        /// <returns></returns>
        public static IList<IList<int>> FindSolution(CustomFunction customfunction, int z)
        {
            var res = new List<IList<int>>();
            int iMax = 1000, jMax = 1000;
            for (int i = 1; i <= iMax; i++)
            for (int j = 1; j <= jMax; j++)
                if (customfunction.f(i, j) == z)
                {
                    res.Add(new List<int>() {i, j});
                    jMax = j - 1;
                    break;
                }

            return res;
        }

        /// <summary>
        /// Circular Permutation in Binary Representation (Not Mine - Gray Code)
        /// </summary>
        /// <param name="n"></param>
        /// <param name="start"></param>
        /// <returns></returns>
        public static IList<int> CircularPermutation(int n, int start)
        {
            var res = new List<int>();
            for (int i = 0; i < 1 << n; ++i)
                res.Add(start ^ i ^ i >> 1);
            return res;
        }

        /// <summary>
        /// Maximum Length of a Concatenated String with Unique Characters (Mine)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int MaxLength(IList<string> arr)
        {
            int res = 0, len = arr.Count;
            for (int i = 0; i < len; i++)
            {
                int curr = 0;
                var set = new HashSet<char>();
                bool canAdd2 = true;
                foreach (var ch in arr[i])
                {
                    if (!set.Add(ch))
                    {
                        canAdd2 = false;
                        break;
                    }
                }

                if(!canAdd2)
                    continue;

                curr += arr[i].Length;
                res = Math.Max(res, curr);

                int j = 0;
                while (j < len)
                {
                    if (j != i)
                    {
                        bool canAdd = true;
                        var set2= new HashSet<int>();
                        foreach (var ch in arr[j])
                        {
                            if (!set.Add(ch))
                            {
                                set.RemoveWhere(c => set2.Contains(c));
                                canAdd = false;
                                break;
                            }
                            else set2.Add(ch);
                        }

                        if (canAdd)
                        {
                            curr += arr[j].Length;
                            res = Math.Max(res, curr);
                        }
                    }

                    j++;
                }
            }

            return res;
        }
    }
}
