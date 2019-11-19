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

            foreach (var arr in list)
            {
                int count = 0;
                for (int i = 0; i <= result.Count; i++)
                {
                    if (count > arr[1])
                    {
                        result.Insert(i - 1, arr);
                        break;
                    }

                    if (i == result.Count)
                    {
                        if (count == arr[1])
                            result.Add(arr);
                        break;
                    }

                    if (result[i][0] >= arr[0])
                        count++;
                }
            }

            return result.ToArray();
        }
    }
}
