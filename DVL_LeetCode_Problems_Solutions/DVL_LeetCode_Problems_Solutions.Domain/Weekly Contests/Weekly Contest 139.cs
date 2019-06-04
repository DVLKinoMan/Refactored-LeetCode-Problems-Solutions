using System;
using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Greatest Common Divisor of Strings (Mine)
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public static string GcdOfStrings(string str1, string str2)
        {
            string divisor = str1;
            string str = str2;
            if (str1.Length > str2.Length)
            {
                str = str1;
                divisor = str2;
            }

            for (int i = 1; i < divisor.Length; i++)
            {
                if (divisor.Length % i != 0)
                    continue;

                string currStr = divisor.Substring(0, divisor.Length / i);
                if (IsDivisor(divisor, currStr) && IsDivisor(str, currStr))
                    return currStr;
            }

            return string.Empty;
        }

        private static bool IsDivisor(string str, string divisor)
        {
            if (str.Length == 0 || divisor.Length>str.Length)
                return false;

            int currIndex = 0;
            while (currIndex < str.Length)
            {
                if (currIndex + divisor.Length - 1 > str.Length || str.Substring(currIndex, divisor.Length) != divisor)
                    return false;

                currIndex += divisor.Length;
            }

            return true;
        }

        /// <summary>
        /// Flip Columns For Maximum Number of Equal Rows (Mine)
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static int MaxEqualRowsAfterFlips(int[][] matrix)
        {
            int maxRows = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                int first = matrix[i][0];
                if (matrix[i].All(i1 => i1 == first))
                    maxRows++;
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int currRows = 0;
                for (int j = i + 1; j < matrix.GetLength(0); j++)
                {
                    bool equal = matrix[i][0] == matrix[j][0], satisfies = true;
                    for (int k = 1; k < matrix[i].Length; k++)
                    {
                        if ((!equal && matrix[i][k] == matrix[j][k]) || (equal && matrix[i][k] != matrix[j][k]))
                        {
                            satisfies = false;
                            break;
                        }
                    }

                    if (satisfies)
                        currRows++;
                }

                maxRows = Math.Max(currRows, maxRows);
            }

            return maxRows;
        }

        /// <summary>
        /// Adding Two Negabinary Numbers (Not Mine)
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <returns></returns>
        public static int[] AddNegabinary(int[] arr1, int[] arr2)
        {
            var res = new List<int>();
            int bit = 0, carry = 0, sz = Math.Max(arr1.Length, arr2.Length);
            for (bit = 0; bit < sz || carry != 0; ++bit)
            {
                int b1 = bit < arr1.Length ? arr1[arr1.Length - bit - 1] : 0;
                int b2 = bit < arr2.Length ? arr2[arr2.Length - bit - 1] : 0;
                int sum = b1 + b2 + carry;
                res.Add(Math.Abs(sum) % 2);
                carry = sum < 0 ? 1 : sum > 1 ? -1 : 0;
            }

            while (res.Count > 1 && res.Last() == 0)
                res.RemoveAt(res.Count - 1);
            res.Reverse();

            return res.ToArray();
        }

    }
}
