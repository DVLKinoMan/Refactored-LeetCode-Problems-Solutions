using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Queue Reconstruction by Height (Mine)
        /// </summary>
        /// <param name="people"></param>
        /// <returns></returns>
        public static int[][] ReconstructQueue(int[][] people)
        {
            var list = people.OrderBy(p => p[1]).ToList();
            var result = new List<int[]>();

            while (list.Count != 0)
            {
                var first = list.First();
                list.RemoveAt(0);

                int count = 0;
                bool hasFound = false;
                for (int i = 0; i < result.Count; i++)
                {
                    if (count > first[1])
                    {
                        result.Insert(i - 1, first);
                        hasFound = true;
                        break;
                    }

                    if (result[i][0] >= first[0])
                        count++;
                }

                if (!hasFound)
                {
                    if (count == first[1])
                    {
                        hasFound = true;
                        result.Add(first);
                    }
                    else if (count > first[1])
                    {
                        hasFound = true;
                        result.Insert(result.Count - 1, first);
                    }
                }

                if (!hasFound)
                    list.Add(first);
            }

            return result.ToArray();
        }
    }
}
