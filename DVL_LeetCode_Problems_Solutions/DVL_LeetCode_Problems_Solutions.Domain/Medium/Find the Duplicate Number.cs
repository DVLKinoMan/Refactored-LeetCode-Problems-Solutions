using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        public static int FindDuplicate(int[] nums)
        {
            //for (int i = 0; i < nums.Length; i++)
            //    for (int j = i + 1; j < nums.Length; j++)
            //        if (nums[i] == nums[j])
            //            return nums[i];

            //throw new NotImplementedException("Problem Description was not right");

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
    }
}
