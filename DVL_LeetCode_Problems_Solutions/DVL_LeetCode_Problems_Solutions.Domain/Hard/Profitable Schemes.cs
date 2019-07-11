using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        public static int ProfitableSchemes(int G, int P, int[] group, int[] profit)
        {
            int count = 0;
            ProfitableSchemesHelper(-1, group, profit, G, P, ref count, 0, 0);
            return count;
        }

        private static void ProfitableSchemesHelper(int index, int[] group, int[] profit, int G, int P, ref int count, int groupSum, int profitSum)
        {
            for (int i = ++index; i < profit.Length; i++)
            {
                if (groupSum + group[i] > G)
                    continue;
                if (profitSum + profit[i] >= P)
                    count++;
                ProfitableSchemesHelper(i, group, profit, G, P, ref count, groupSum + group[i], profitSum + profit[i]);
            }
        }
    }
}
