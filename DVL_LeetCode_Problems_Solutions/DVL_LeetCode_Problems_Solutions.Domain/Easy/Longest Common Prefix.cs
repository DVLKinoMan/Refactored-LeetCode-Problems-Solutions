using System.Text;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// LongestCommonPrefix
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
                return string.Empty;

            int index = 0;
            StringBuilder result = new StringBuilder();
            while (true)
            {
                if (strs[0].Length - 1 < index)
                    return result.ToString();

                char ch = strs[0][index];
                for (int i = 1; i < strs.Length; i++)
                    if (strs[i].Length - 1 < index || strs[i][index] != ch)
                        return result.ToString();
                result.Append(ch);
                index++;
            }
        }
    }
}
