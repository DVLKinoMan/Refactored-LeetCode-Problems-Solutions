using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Number of Sub-arrays of Size K and Average Greater than or Equal to Threshold (Mine)
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="k"></param>
        /// <param name="threshold"></param>
        /// <returns></returns>
        public static int NumOfSubarrays(int[] arr, int k, int threshold)
        {
            int sum = arr.Take(k).Sum();
            int count = (double) sum / k >= threshold ? 1 : 0;
            for (int i = 1; i <= arr.Length - k; i++)
            {
                sum -= arr[i - 1];
                sum += arr[i + k - 1];
                count += (double) sum / k >= threshold ? 1 : 0;
            }

            return count;
        }
    }
}