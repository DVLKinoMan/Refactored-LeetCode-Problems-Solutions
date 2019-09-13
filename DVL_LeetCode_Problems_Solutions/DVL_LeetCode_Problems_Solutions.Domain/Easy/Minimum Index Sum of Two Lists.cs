using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Minimum Index Sum of Two Lists (Mine)
        /// </summary>
        /// <param name="list1"></param>
        /// <param name="list2"></param>
        /// <returns></returns>
        public static string[] FindRestaurant(string[] list1, string[] list2)
        {
            var list = new List<string>();
            int sum = int.MaxValue;
            for (int i = 0; i < list1.Length; i++)
            for (int j = 0; j < list2.Length; j++)
                if (list1[i] == list2[j])
                {
                    if (i + j < sum)
                    {
                        list = new List<string>();
                        list.Add(list1[i]);
                        sum = i + j;
                    }
                    else if (i + j == sum)
                        list.Add(list1[i]);
                }

            return list.ToArray();
        }
    }
}
