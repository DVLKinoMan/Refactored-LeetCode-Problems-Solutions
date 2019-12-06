using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Sort an Array (Mine)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static IList<int> SortArray(int[] nums)
        {
            MergeSort(0, nums.Length - 1);
            return nums;

            void MergeSort(int i, int j)
            {
                if (i == j)
                    return;
                int med = (i + j) / 2;
                MergeSort(i, med);
                MergeSort(med + 1, j);
                Merge(i, med, med + 1, j);
            }

            void Merge(int i1, int j1, int i2, int j2)
            {
                int fIndex = i1, sIndex = i2;
                int[] arr = new int[j2 - i1 + 1];
                int indexToInsert = 0;
                while (indexToInsert != arr.Length)
                {
                    if (fIndex > j1 || (sIndex <= j2 && nums[fIndex] > nums[sIndex]))
                        arr[indexToInsert++] = nums[sIndex++];
                    else arr[indexToInsert++] = nums[fIndex++];
                }

                for (int i = 0; i < arr.Length; i++)
                    nums[i1 + i] = arr[i];
            }
        }
    }
}
