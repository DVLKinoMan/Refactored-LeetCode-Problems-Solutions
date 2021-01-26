using System.Text;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Basic Calculator (Mine)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int Calculate(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;
            int sum = 0, curIndex = 0;

            int mul = 1;
            var builder = new StringBuilder();
            while (curIndex < s.Length)
            {
                if (s[curIndex] == '(')
                {
                    int bal = 1, stIndex = ++curIndex;
                    for (; curIndex < s.Length; curIndex++)
                    {
                        if (s[curIndex] == '(')
                            bal++;
                        else if (s[curIndex] == ')')
                            bal--;
                        if (bal == 0)
                            break;
                    }

                    sum += mul * Calculate(s.Substring(stIndex, curIndex - stIndex));
                    curIndex++;
                    continue;
                }

                if (s[curIndex] == '+')
                {
                    if (builder.Length != 0)
                        sum += mul * int.Parse(builder.ToString());
                    mul = 1;
                    builder = new StringBuilder();
                }
                else if (s[curIndex] == '-')
                {
                    if (builder.Length != 0)
                        sum += mul * int.Parse(builder.ToString());
                    mul = -1;
                    builder = new StringBuilder();
                }
                else if (s[curIndex] != ' ')
                    builder.Append(s[curIndex]);

                curIndex++;
            }

            return builder.Length == 0 ? sum : sum + mul * int.Parse(builder.ToString());
        }
    }
}
