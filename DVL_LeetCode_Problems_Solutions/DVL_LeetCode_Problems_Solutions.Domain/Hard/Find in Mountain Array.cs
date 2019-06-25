using DVL_LeetCode_Problems_Solutions.Domain.Classes;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Find in Mountain Array (Mine)
        /// </summary>
        /// <param name="target"></param>
        /// <param name="mountainArr"></param>
        /// <returns></returns>
        public static int FindInMountainArray(int target, MountainArray mountainArr)
        {
            int a = 0, b = mountainArr.Length() - 1;
            int peek;
            while (true)
            {
                int curr = (a + b) / 2;
                var (left, currValue, right) = (curr - 1 < 0 ? -1 : mountainArr.Get(curr - 1), 
                                                mountainArr.Get(curr),
                                                curr + 1 >= mountainArr.Length() ? mountainArr.Length() : mountainArr.Get(curr + 1));
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
            return FindInMountainArrayHelper(target, mountainArr, peek, mountainArr.Length() - 1, false);
        }

        private static int FindInMountainArrayHelper(int target, MountainArray mountainArr, int a, int b, bool asc = true)
        {
            while (a <= b)
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
