using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Rabbits in Forest (Mine)
        /// </summary>
        /// <param name="answers"></param>
        /// <returns></returns>
        public static int NumRabbits(int[] answers)
        {
            var dic=new Dictionary<int, int>();
            foreach (var ans in answers)
            {
                if (dic.ContainsKey(ans))
                    dic[ans]++;
                else dic.Add(ans, 1);
            }

            int count = 0;
            foreach (var pair in dic)
                count += (pair.Value / (pair.Key + 1)) * (pair.Key + 1) + (pair.Value % (pair.Key) > 0 ? pair.Key + 1 : 0);

            return count;
        }
    }
}
