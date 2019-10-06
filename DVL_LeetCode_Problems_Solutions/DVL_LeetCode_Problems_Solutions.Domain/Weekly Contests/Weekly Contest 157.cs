using System;
using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Longest Arithmetic Subsequence of Given Difference (Mine)
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="difference"></param>
        /// <returns></returns>
        public static int LongestSubsequence(int[] arr, int difference)
        {
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (dic.ContainsKey(arr[i]))
                {
                    int value = dic[arr[i]] + 1;
                    dic.Remove(arr[i]);
                    if (dic.ContainsKey(arr[i] + difference))
                        dic[arr[i] + difference] = Math.Max(value, dic[arr[i] + difference]);
                    else dic.Add(arr[i] + difference, value);
                }
                else if (!dic.ContainsKey(arr[i] + difference))
                    dic.Add(arr[i] + difference, 1);
            }

            return dic.Values.Max();
        }

        /// <summary>
        /// Path with Maximum Gold (Mine)
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public static int GetMaximumGold(int[][] grid)
        {
            int maxGold = 0, m = grid.Length, n = grid[0].Length;

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    if (grid[i][j] != 0)
                    {
                        var list = new HashSet<(int, int)>(){ (i,j) };
                        maxGold = Math.Max( maxGold, Dfs(list,(i, j), grid[i][j]));
                    }

            return maxGold;

            int Dfs(HashSet<(int,int)> visitedCoos, (int i,int j) coo, int gold)
            {
                int max = gold;
                //up move
                if (coo.i != 0 && grid[coo.i - 1][coo.j] != 0 && visitedCoos.Add((coo.i-1, coo.j)))
                {
                    var tup = (coo.i - 1, coo.j);
                    max = Math.Max(max, Dfs(visitedCoos, tup, gold + grid[coo.i - 1][coo.j]));
                    visitedCoos.Remove(tup);
                }
                
                //down move
                if (coo.i != m - 1 && grid[coo.i + 1][coo.j] != 0 && visitedCoos.Add((coo.i + 1, coo.j)))
                {
                    var tup = (coo.i + 1, coo.j);
                    max = Math.Max(max, Dfs(visitedCoos, tup, gold + grid[coo.i + 1][coo.j]));
                    visitedCoos.Remove(tup);
                }
                
                //left move
                if (coo.j != 0 && grid[coo.i][coo.j - 1] != 0 && visitedCoos.Add((coo.i, coo.j - 1)))
                {
                    var tup = (coo.i, coo.j - 1);
                    max = Math.Max(max, Dfs(visitedCoos, tup, gold + grid[coo.i][coo.j - 1]));
                    visitedCoos.Remove(tup);
                }  
                
                //right move
                if (coo.j != n - 1 && grid[coo.i][coo.j + 1] != 0 && visitedCoos.Add((coo.i, coo.j + 1)))
                {
                    var tup = (coo.i, coo.j + 1);
                    max = Math.Max(max, Dfs(visitedCoos, tup, gold + grid[coo.i][coo.j + 1]));
                    visitedCoos.Remove(tup);
                }

                return max;
            }
        }
    }
}
