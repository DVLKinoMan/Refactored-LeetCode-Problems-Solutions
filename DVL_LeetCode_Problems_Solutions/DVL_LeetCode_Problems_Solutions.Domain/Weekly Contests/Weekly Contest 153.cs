using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Distance Between Bus Stops (Mine)
        /// </summary>
        /// <param name="distance"></param>
        /// <param name="start"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public static int DistanceBetweenBusStops(int[] distance, int start, int destination)
        {
            int index = start, sum1 = 0, sum2 = 0;
            while (true)
            {
                if (index == destination)
                    break;
                sum1 += distance[index];
                index = (index + 1) % distance.Length;
            }

            index = (start - 1) < 0 ? distance.Length + (start - 1) : start - 1; ;
            while (true)
            {
                sum2 += distance[index];
                if (index == destination)
                    break;
                index = (index - 1) < 0 ? distance.Length + (index - 1) : index - 1;
            }

            return Math.Min(sum1, sum2);
        }

        /// <summary>
        /// Day of the Week (Mine)
        /// </summary>
        /// <param name="day"></param>
        /// <param name="month"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public static string DayOfTheWeek(int day, int month, int year)
        {
            var dateTime = new DateTime(year, month, day);
            return dateTime.DayOfWeek.ToString();
        }

        /// <summary>
        /// Maximum Subarray Sum with One Deletion (Not Mine)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int MaximumSum(int[] arr)
        {
            int[] forward = new int[arr.Length], backward = new int[arr.Length];
            int curMax = arr[0], max = arr[0];

            forward[0] = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                curMax = Math.Max(arr[i], curMax + arr[i]);
                max = Math.Max(max, curMax);
                forward[i] = curMax;
            }

            curMax = arr[arr.Length - 1];
            max = arr[arr.Length - 1];
            backward[arr.Length - 1] = arr[arr.Length - 1];

            for (int i = arr.Length - 2; i >= 0; i--)
            {
                curMax = Math.Max(arr[i], curMax + arr[i]);
                max = Math.Max(max, curMax);
                backward[i] = curMax;
            }

            int res = max;
            for (int i = 1; i < arr.Length - 1; i++)
                res = Math.Max(res, forward[i - 1] + backward[i + 1]);

            return res;
        }
    }
}
