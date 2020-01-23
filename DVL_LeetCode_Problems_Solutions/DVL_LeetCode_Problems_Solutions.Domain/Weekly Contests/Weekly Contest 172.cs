namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Maximum 69 Number (Mine)
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int Maximum69Number(int num)
        {
            string str = num.ToString();
            string res = str;

            for (int i = 0; i < str.Length; i++)
                if (str[i] == '6')
                {
                    res = str.Substring(0, i) + '9' + str.Substring(i + 1);
                    break;
                }

            return int.Parse(res);
        }
    }
}
