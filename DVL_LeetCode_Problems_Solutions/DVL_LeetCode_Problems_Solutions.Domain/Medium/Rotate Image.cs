using System;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Rotate Image (My Solution)
        /// </summary>
        /// <param name="matrix"></param>
        public static void Rotate(int[][] matrix)
        {
            int iStart = 0, jStart = 0, length = matrix.Length - 1;

            while (length >= 1)
            {
                int ringMaxJ = jStart + length;
                int ringMaxI = iStart + length;
                for (int j = jStart; j < ringMaxJ; j++)
                {
                    int c = 1;
                    var fCoo = Tuple.Create(iStart, j);
                    var sCoo = Tuple.Create(iStart + (j - jStart), ringMaxJ);
                    int valueOfSecond = matrix[fCoo.Item1][fCoo.Item2];
                    while (true)
                    {
                        //Swaping
                        matrix[sCoo.Item1][sCoo.Item2] += valueOfSecond;
                        valueOfSecond = matrix[sCoo.Item1][sCoo.Item2] - valueOfSecond;
                        matrix[sCoo.Item1][sCoo.Item2] -= valueOfSecond;

                        if (c == 4)
                            break;

                        //Assign Coordinates
                        fCoo = sCoo;
                        if (c % 2 == 1)
                            sCoo = fCoo.Item2 == ringMaxJ
                                ? Tuple.Create(ringMaxI, ringMaxJ - (fCoo.Item1 - iStart))
                                : Tuple.Create(iStart, jStart + (ringMaxI - fCoo.Item1));
                        else
                            sCoo = Tuple.Create(iStart + (fCoo.Item2 - jStart), jStart);
                        c++;
                    }
                }

                iStart++;
                jStart++;
                length -= 2;
            }
        }
        

        //private static Tuple<int, int> CalcNextCoordinate(int i, int j, int c, int n)
        //{

        //    n-c*2
        //    int c = j >= n / 2 ? n - j - 1 : j;


        //}
    }
}
