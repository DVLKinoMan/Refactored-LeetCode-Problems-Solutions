using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Squares of a Sorted Array (Mine)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int[] SortedSquares(int[] A)
        {
            //var list = new List<int>();
            //var list2 = new List<int>();
            //int i = 0;
            //while (i<A.Length && A[i] < 0)
            //    list.Add(A[i++]);
            //while (i < A.Length)
            //    list2.Add(A[i++]);

            //int start = 0;
            //for (i = list.Count - 1; i >= 0; i--)
            //    start = InsertionSort(list2, Math.Abs(list[i]), start);

            //return list2.Select(num => num * num).ToArray();

            //int InsertionSort(List<int> l, int val, int st = 0)
            //{
            //    int a = st, b = l.Count - 1;
            //    while (a <= b)
            //    {
            //        int mid = (a + b) / 2;
            //        if (l[mid] == val)
            //        {
            //            l.Insert(mid, val);
            //            return mid;
            //        }
            //        else if (l[mid] > val)
            //            b = mid - 1;
            //        else a = mid + 1;
            //    }

            //    l.Insert(a, val);
            //    return a;
            //}

            int[] res = new int[A.Length];
            int left = 0, right = A.Length - 1;
            for (int i = A.Length - 1; i >= 0; i--)
            {
                if (Math.Abs(A[left]) > Math.Abs(A[right]))
                    res[i] = A[left] * A[left++];
                else res[i] = A[right] * A[right++];
            }

            return res;
        }
    }
}
