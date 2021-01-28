using System;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Maximum Gap (Not Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int MaximumGap(int[] nums)
        {
            if (nums.Length < 2)
                return 0;
            if (nums.Length == 2)
                return Math.Abs(nums[1] - nums[0]);

            int min = nums.Min();
            int max = nums.Max();

            int bucketSize = Math.Max(1, (max - min) / (nums.Length - 1));
            int bucketCount = (max - min) / bucketSize + 1;

            (int? min, int? max)[] buckets = new (int? min, int? max)[bucketCount];

            foreach (var num in nums)
            {
                var idx = (num - min) / bucketSize;
                var current = buckets[idx];

                current.min = Math.Min(current.min.GetValueOrDefault(int.MaxValue), num);
                current.max = Math.Max(current.max.GetValueOrDefault(int.MinValue), num);
                buckets[idx] = current;
            }

            int res = 0;

            int prevGapIdx = -1;
            for (int i = 0; i < bucketCount; i++)
            {
                if (!buckets[i].min.HasValue)
                    continue;

                var prev = prevGapIdx >= 0 ? buckets[prevGapIdx].max.Value : min;
                res = Math.Max(res, buckets[i].min.Value - prev);
                prevGapIdx = i;
            }

            return res;
        }
    }
}
