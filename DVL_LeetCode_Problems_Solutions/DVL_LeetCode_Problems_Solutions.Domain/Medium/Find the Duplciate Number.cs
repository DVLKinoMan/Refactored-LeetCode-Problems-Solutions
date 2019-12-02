namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Find the Duplicate Number (Not Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int FindDuplicate(int[] nums)
        {
            if (nums.Length > 1)
            {
                int slow = nums[0];
                int fast = nums[nums[0]];
                while (slow != fast)
                {
                    slow = nums[slow];
                    fast = nums[nums[fast]];
                }

                fast = 0;
                while (fast != slow)
                {
                    fast = nums[fast];
                    slow = nums[slow];
                }

                return slow;
            }

            return -1;

            //My Version (Slow)
            //for (int i = 0; i < nums.Length; i++)
            //    for (int j = i + 1; j < nums.Length; j++)
            //        if (nums[i] == nums[j])
            //            return nums[i];

            //throw new NotImplementedException("Problem Description was not right");

        }
    }
}
