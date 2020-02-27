using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// DI String Match (Mine) 
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        public static int[] DiStringMatch(string S)
        {
            int incCount = S.Count(ch => ch == 'I'), n = S.Length, decCount = n - incCount;
            var result = new int[n + 1];

            result[0] = n - incCount;
            int index = 1;
            foreach (var ch in S)
            {
                if (ch == 'I')
                {
                    incCount--;
                    result[index] = n - incCount;
                }
                else
                {
                    decCount--;
                    result[index] = decCount;
                }

                index++;
            }

            return result;
        }
    }
}