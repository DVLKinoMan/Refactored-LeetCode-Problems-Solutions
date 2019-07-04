using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Complement of Base 10 Integer (Mine)
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public static int BitwiseComplement(int N)
        {
            var binaryArr = System.Convert.ToString(N, 2).ToArray();
            for(int i = 0; i<binaryArr.Length; i++)
                if (binaryArr[i] == '1')
                    binaryArr[i] = '0';
                else
                    binaryArr[i] = '1';
            if (!binaryArr.Contains('1'))
                return 0;

            return System.Convert.ToInt32(string.Join("", binaryArr.SkipWhile(i => i == '0')), 2);
        }
    }
}
