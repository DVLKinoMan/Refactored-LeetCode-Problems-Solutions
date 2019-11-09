namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Check If It Is a Good Array (Not Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static bool IsGoodArray(int[] nums)
        {
            int x = nums[0], y;
            foreach (var num in nums)
            {
                int a = num;
                while (a > 0)
                {
                    y = x % a;
                    x = a;
                    a = y;
                }
            }

            return x == 1;
        }
    }
}
