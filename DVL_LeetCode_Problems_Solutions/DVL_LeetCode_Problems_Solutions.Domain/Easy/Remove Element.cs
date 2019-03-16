using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Remove_Element
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public static int RemoveElement(int[] nums, int val)
        {
            int i = 0;
            foreach (var num in nums.Where(num => num != val))
            {
                nums[i] = num;
                i++;
            }

            return i;
        }

        /// <summary>
        /// Remove_Element (Not Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public static int RemoveElementWithLessMemory(int[] nums, int val)
        {
            int i = 0;
            int j = nums.Length - 1;
            while (i <= j)
            {
                if (nums[i] != val)
                {
                    i++;
                }
                else
                {
                    nums[i] = nums[j];
                    j--;
                }
            }

            return j + 1;
        }
    }
}
