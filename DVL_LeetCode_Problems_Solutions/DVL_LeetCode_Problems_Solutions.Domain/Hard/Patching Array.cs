namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Patching Array (Not Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int MinPatches(int[] nums, int n)
        {
            long miss = 1;
            int added = 0, i = 0;
            while (miss <= n)
            {
                if (i < nums.Length && nums[i] <= miss)
                    miss += nums[i++];
                else
                {
                    miss += miss;
                    added++;
                }
            }

            return added;
        }
    }
}
