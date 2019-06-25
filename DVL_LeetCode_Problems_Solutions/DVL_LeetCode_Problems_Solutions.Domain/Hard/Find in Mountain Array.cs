using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        public static int FindInMountainArray(int target, MountainArray mountainArr)
        {
            int a = 0, b = mountainArr.Length() - 1;
            int peek;
            while (true)
            {
                int curr = (a + b) / 2;
                int left = mountainArr.Get(curr - 1), right = mountainArr.Get(curr + 1), currValue = mountainArr.Get(curr);
                if (currValue > left && currValue > right)
                {
                    peek = curr;
                    break;
                }

                if (currValue < right)
                    a = curr + 1;
                else b = curr - 1;

            }

            int res = FindInMountainArrayHelper(target, mountainArr, 0, peek);
            if (res != -1)
                return res;
            return FindInMountainArrayHelper(target, mountainArr, peek, mountainArr.Length(), false);
        }

        private static int FindInMountainArrayHelper(int target, MountainArray mountainArr, int a, int b, bool asc = true)
        {
            while (a < b)
            {
                int curr = (a + b) / 2;
                int get = mountainArr.Get(curr);
                if (get == target)
                    return curr;

                if (get < target)
                {
                    if (asc)
                        a = curr + 1;
                    else b = curr - 1;
                }
                else
                {
                    if (asc)
                        b = curr - 1;
                    else a = curr + 1;
                }
            }

            return -1;
        }
    }
}
