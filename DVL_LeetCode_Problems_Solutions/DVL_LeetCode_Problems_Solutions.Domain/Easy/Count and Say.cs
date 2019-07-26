using System.Text;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Count and Say (Mine)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static string CountAndSay(int n)
        {
            var prevStr = new StringBuilder("1");

            for (int i = 1; i < n; i++)
            {
                var currStr = new StringBuilder();

                char currChar = prevStr[0];
                int count = 1;
                for (int k = 1; k <= prevStr.Length; k++)
                {
                    if (k == prevStr.Length)
                    {
                        currStr.Append(count);
                        currStr.Append(currChar);
                    }
                    else if (prevStr[k] != currChar)
                    {
                        currStr.Append(count);
                        currStr.Append(currChar);
                        count = 1;
                        currChar = prevStr[k];
                    }
                    else if (prevStr[k] == currChar)
                        count++;
                }

                prevStr = currStr;
            }

            return prevStr.ToString();
        }
    }
}
