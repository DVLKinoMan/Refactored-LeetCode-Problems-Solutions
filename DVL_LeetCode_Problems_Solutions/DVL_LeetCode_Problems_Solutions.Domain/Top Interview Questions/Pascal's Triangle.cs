using System.Collections.Generic;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        public static IList<IList<int>> Generate(int numRows)
        {
            var res = new List<IList<int>>();
            if (numRows == 0)
                return res;

            res.Add(new[] {1});
            for (int i = 1; i < numRows; i++)
            {
                var list = new List<int>() {1};
                int j = 0;
                while (j != i - 1)
                {
                    list.Add(res[i - 1][j] + res[i - 1][j + 1]);
                    j++;
                }

                list.Add(1);
                res.Add(list);
            }

            return res;
        }
    }
}