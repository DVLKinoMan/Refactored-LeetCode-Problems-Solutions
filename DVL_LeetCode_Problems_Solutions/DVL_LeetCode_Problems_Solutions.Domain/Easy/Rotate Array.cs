namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Rotate Array (Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        public static void Rotate(int[] nums, int k)
        {
            k %= nums.Length;
            int[] arr =new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
                arr[(i + k) % nums.Length] = nums[i];
            for (int i = 0; i < nums.Length; i++)
                nums[i] = arr[i];
        }
    }
}
