namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Range Sum Query - Mutable (Mine)
        /// </summary>
        public class NumArray
        {
            private int[] sums;
            private int[] originalNums;

            public NumArray(int[] nums)
            {
                sums = new int[nums.Length];
                originalNums = nums;
                if (nums.Length == 0)
                    return;
                sums[0] = nums[0];
                for (int i = 1; i < sums.Length; i++)
                    sums[i] = sums[i - 1] + originalNums[i];
            }

            public void Update(int i, int val)
            {
                int diff = val - originalNums[i];
                originalNums[i] = val;
                for (; i < sums.Length; i++)
                    sums[i] += diff;
            }

            public int SumRange(int i, int j)
            {
                return sums[j] - (i == 0 ? 0 : sums[i - 1]);
            }
        }
    }
}
