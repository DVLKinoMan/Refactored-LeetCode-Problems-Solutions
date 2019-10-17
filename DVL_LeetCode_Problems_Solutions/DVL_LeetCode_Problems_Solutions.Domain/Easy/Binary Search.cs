namespace DVL_LeetCode_Problems_Solutions.Domain.Easy
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Binary Search (Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int Search(int[] nums, int target)
        {
            int st = 0, end = nums.Length - 1;
            while (st < end)
            {
                int index = (st + end) / 2;
                if (nums[index] == target)
                    return index;
                if (nums[index] > target)
                    end = index - 1;
                else st = index + 1;
            }

            return -1;
        }
    }
}
