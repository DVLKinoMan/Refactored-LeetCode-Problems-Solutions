namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Product of Array Except Self (Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] ProductExceptSelf(int[] nums)
        {
            int product = 1, zeroesCount = 0, zeroIndex = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    zeroesCount++;
                    zeroIndex = i;
                }
                else product *= nums[i];
            }

            int[] result = new int[nums.Length];
            if (zeroesCount > 1)
                return result;

            if (zeroesCount == 1)
            {
                result[zeroIndex] = product;
                return result;
            }

            for (int i = 0; i < nums.Length; i++)
                result[i] = product / nums[i];

            return result;
        }
    }
}
