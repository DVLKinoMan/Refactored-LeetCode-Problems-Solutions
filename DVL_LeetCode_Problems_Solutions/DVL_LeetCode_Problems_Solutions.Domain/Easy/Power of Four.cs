using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Power of Four (Mine)
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsPowerOfFour(int num)
        {
           var binaryString = System.Convert.ToString(num, 2);
           var oneIndexes = binaryString.Reverse().Select((ch, i) => (ch, i)).Where(tup => tup.ch == '1').ToArray();
           return oneIndexes.Length == 1 && oneIndexes[0].i % 2 == 0;
            //Not Mine
           //return num > 0 && (num & (num - 1)) == 0 && (num - 1) % 3 == 0;
        }
    }
}
