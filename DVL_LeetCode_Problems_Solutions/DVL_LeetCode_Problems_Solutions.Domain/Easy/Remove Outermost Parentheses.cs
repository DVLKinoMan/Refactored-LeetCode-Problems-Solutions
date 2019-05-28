using System.Text;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Remove Outermost Parentheses (Mine)
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public static string RemoveOuterParentheses(string S)
        {
            int index = 0, prevIndex = 0;
            var builder = new StringBuilder();
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == '(')
                    index++;
                else index--;

                if (index == 0)
                {
                    if (i != prevIndex + 1)
                        builder.Append(S.Substring(prevIndex + 1, i - prevIndex - 1));
                    prevIndex = i + 1;
                }
            }

            return builder.ToString();
        }
    }
}
