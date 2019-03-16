using System.Linq;
using System.Text;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// ZigZag_Conversion
        /// </summary>
        /// <param name="s"></param>
        /// <param name="numRows"></param>
        /// <returns></returns>
        public static string Convert(string s, int numRows)
        {
            if (string.IsNullOrEmpty(s) || numRows == 1)
                return s;

            var divideBy2Nums = Enumerable.Range(0, numRows).Select(num => num * 2).Reverse().ToList();
            var result = new StringBuilder();
            for (int i = 0; i < numRows; i++)
            {
                if (i >= s.Length)
                    return result.ToString();

                result.Append(s[i]);
                int mod = i % (numRows - 1);

                int index = i + divideBy2Nums[mod];
                while (index < s.Length)
                {
                    result.Append(s[index]);
                    if (mod != 0 && (index - i) % divideBy2Nums[0] != 0)
                        index += divideBy2Nums[0] - divideBy2Nums[mod];
                    else index += divideBy2Nums[mod];
                }
            }

            return result.ToString();
        }
    }
}
