﻿using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        public static int FirstMissingPositive(int[] nums)
        {
            //Did not work
            //int i = 0, i2 = 0, iLast = -1, iValue = nums[i];
            //while (true)
            //{
            //    if (i == nums.Length)
            //    {
            //        if (iLast != -1)
            //        {
            //            i = iLast;
            //            iLast = -1;
            //        }
            //        else break;
            //    }

            //    if (nums[i] != i && nums[i] >= 0 && nums[i] < nums.Length)
            //    {
            //        i2 = nums[nums[i]];
            //        nums[nums[i]] = nums[i];
            //        if (iLast == -1)
            //            iLast = i;
            //        i = i2;
            //        continue;
            //    }
            //    else i2 = 0;

            //    i++;
            //}
           
            //Works but Space is not Constant
            //int[] nums2 = new int[nums.Length + 1];
            //for (int i = 0; i < nums.Length; i++)
            //    if (nums[i] > 0 && nums[i] < nums2.Length)
            //        nums2[nums[i]] = nums[i];

            //int i3 = 1;
            //while (true)
            //{
            //    if (i3 >= nums2.Length || nums2[i3] != i3)
            //        return i3;
            //    i3++;
            //}

            if (nums.Length == 0)
                return 1;

            int i = 0, iValue = nums[i];
            while (true)
            {
                if (i == nums.Length)
                    break;
                if (iValue > 0 && iValue <= nums.Length && nums[iValue - 1] != iValue)
                {
                    int temp = nums[iValue - 1];
                    nums[iValue - 1] = iValue;
                    iValue = temp;
                }
                else if (++i < nums.Length)
                    iValue = nums[i];
            }

            int i3 = 1;
            while (true)
            {
                if (i3 > nums.Length || nums[i3 - 1] != i3)
                    return i3;
                i3++;
            }
        }
    }
}
