namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Additive Number (My Solution)
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsAdditiveNumber(string num)
        {
            for (int i = 1; i < num.Length - 1; i++)
            {
                if (num[0] == '0' && i > 1)
                    break;
                if (long.TryParse((num.Substring(0, i)), out long firstNum))
                {
                    for (int j = 1; i + j < num.Length; j++)
                    {
                        if (num[i] == '0' && j > 1)
                            continue;
                        if (long.TryParse(num.Substring(i, j), out long secNum))
                            if (IsAdditiveNumberHelper(firstNum, secNum, i + j, num))
                                return true;
                    }
                }
            }

            return false;
        }

        private static bool IsAdditiveNumberHelper(long firstNum, long secNum, int index, string num)
        {
            if (index >= num.Length)
                return true;

            long sum = firstNum + secNum;
            string sumStr = sum.ToString();
            if (num.IndexOf(sumStr, index) == index)
                return IsAdditiveNumberHelper(secNum, sum, index + sumStr.Length, num);

            return false;
        }
    }
}
