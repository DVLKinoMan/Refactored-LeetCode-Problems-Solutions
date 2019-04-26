using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Minimum Domino Roations for Equal Row (My Solution)
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static int MinDominoRotations(int[] A, int[] B)
        {
            int f = A[0], s = B[0];
            int[] arrSwaps = new int[] {0, 0, 1, 1};
            for (int i = 1; i < A.Length; i++)
            {
                if (arrSwaps[0] != -1)
                {
                    if (B[i] == f && A[i] != f)
                        arrSwaps[0]++;
                    else if (A[i] != f)
                        arrSwaps[0] = -1;
                }

                if (arrSwaps[1] != -1)
                {
                    if (A[i] == s && B[i] != s)
                        arrSwaps[1]++;
                    else if (B[i] != s)
                        arrSwaps[1] = -1;
                }

                if (arrSwaps[2] != -1)
                {
                    if (B[i] == s && A[i] != s)
                        arrSwaps[2]++;
                    else if (A[i] != s)
                        arrSwaps[2] = -1;
                }

                if (arrSwaps[3] != -1)
                {
                    if (A[i] == f && B[i] != f)
                        arrSwaps[3]++;
                    else if (B[i] != f)
                        arrSwaps[3] = -1;
                }
            }

            int min = arrSwaps.Where(i => i != -1).DefaultIfEmpty(-1).Min();
            return min;
        }
    }
}
