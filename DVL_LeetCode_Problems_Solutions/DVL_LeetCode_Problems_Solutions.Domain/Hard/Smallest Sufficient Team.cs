﻿using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Smallest Sufficient Team (Not Mine)
        /// </summary>
        /// <param name="req_skills"></param>
        /// <param name="people"></param>
        /// <returns></returns>
        public static int[] SmallestSufficientTeam(string[] req_skills, IList<IList<string>> people)
        {
            int ns = req_skills.Length, np = people.Count;
            var map = new Dictionary<string, int>();
            for (int i = 0; i < ns; ++i)
                map.Add(req_skills[i], i);

            var suff = new List<List<int>>();
            int len = 1 << ns;
            for (int i = 0; i < len; i++)
                suff.Add(null);
            suff[0] = new List<int>();

            for (int i = 0; i < np; ++i)
            {
                int skill = 0;
                foreach (string s in people[i])
                    skill |= (1 << map[s]);
                for (int prev = 0; prev < suff.Count; ++prev)
                {
                    if (suff[prev] == null)
                        continue;
                    int comb = prev | skill;
                    if (suff[comb] == null || suff[prev].Count + 1 < suff[comb].Count)
                    {
                        suff[comb] = new List<int>(suff[prev]);
                        suff[comb].Add(i);
                    }
                }
            }
            var res = suff[(1 << ns) - 1];
            int[] arr = new int[res.Count()];
            for (int i = 0; i < arr.Length; ++i)
                arr[i] = res[i];

            return arr;
        }
    }
}
