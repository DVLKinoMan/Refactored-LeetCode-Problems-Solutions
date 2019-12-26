using System.Text;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Reverse Only Letters (Mine)
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public static string ReverseOnlyLetters(string S)
        {
            var builder = new StringBuilder(S);
            int i = 0, j = S.Length - 1;
            while (i < j)
            {
                bool iIsLetter = char.IsLetter(builder[i]), jIsLetter = char.IsLetter(builder[j]);
                if (iIsLetter && jIsLetter)
                {
                    var ch = builder[i];
                    builder[i] = builder[j];
                    builder[j] = ch;
                    i++;
                    j--;
                }
                else if (!iIsLetter)
                    i++;
                else //!jIsLetter
                    j--;
            }

            return builder.ToString();
        }
    }
}
