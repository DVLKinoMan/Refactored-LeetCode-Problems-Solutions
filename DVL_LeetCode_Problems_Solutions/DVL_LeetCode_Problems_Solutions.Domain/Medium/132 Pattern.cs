using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// 132 Pattern (Not Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static bool Find132pattern(int[] nums)
        {
            int s3 = int.MinValue;
            var st = new Stack<int>();
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] < s3) return true;
                else while (st.Count!=0 && nums[i] > st.Peek())
                {
                    s3 = st.Pop();
                }
                st.Push(nums[i]);
            }
            return false;
        }
    }
}
