using System;
using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Do not works and it is leetcode's fault i think
        /// </summary>
        /// <param name="blocked"></param>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static bool IsEscapePossible(int[][] blocked, int[] source, int[] target)
        {
            if (blocked.Length == 0)
                return true;

            var set = new HashSet<(int,int)>();
            foreach(var ele in blocked)
                set.Add((ele[0], ele[1]));

            return checkHelper(set, source) && checkHelper(set, target);
        }


        public static bool checkHelper(HashSet<(int,int)> set, int[] source)
        {
            int max_size = set.Count()*2;
            int[][] dirs = new int[][] { new int[]{ -1, 0 }, new int[]{ 1, 0 }, new int[]{ 0, 1 }, new int[]{ 0, -1 } };

            var queue = new Queue<int[]>();
            queue.Enqueue(source);

            var seen = new HashSet<(int,int)>();
            seen.Add((source[0],source[1]));
            int level = 0;
            while (true)
            {
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    int[] cur = queue.Dequeue();
                    foreach (var dir in dirs)
                    {
                        int x = dir[0] + cur[0];
                        int y = dir[1] + cur[1];

                        if (x >= 0 && x < (int)(1e6) && y >= 0 && y < (int)(1e6) && !seen.Contains((x, y)) && !set.Contains((x, y)))
                        {
                            seen.Add((x,y));
                            queue.Enqueue(new int[] { x, y });
                        }
                    }
                }

                level++;
                if (level == max_size)
                    return true;

                if (queue.Count == 0)
                    return false;
            }
        }
    }
}
