using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        public static int[] SmallestSufficientTeam(string[] req_skills, IList<IList<string>> people)
        {
            int ns = req_skills.Length, np = people.Count;
            var map = new Dictionary<String, int>();
            for (int i = 0; i < ns; ++i)
                map.Add(req_skills[i], i);
            var suff = new List<List<int>>();//[1 << ns]
            suff.Add(new List<int>());
            for (int i = 0; i < np; ++i)
            {
                int skill = 0;
                foreach (String s in people[i]) skill |= (1 << map[s]);
                for (int prev = 0; prev < suff.Count; ++prev)
                {
                    if (prev >= suff.Count()) continue;
                    int comb = prev | skill;
                    if (comb < suff.Count() || suff[prev].Count + 1 < suff[comb].Count)
                    {
                        suff[comb] = new List<int>(suff[prev]);
                        suff[comb].Add(i);
                    }
                }
            }
            List<int> res = suff[(1 << ns) - 1];
            int[] arr = new int[res.Count()];
            for (int i = 0; i < arr.Length; ++i) arr[i] = res[i];
            return arr;

            //int n = req_skills.Length, m = people.Count();
            //key = { v: i for i, v in enumerate(req_skills)}
            //dp = { 0: []
            //}
            //for i, p in enumerate(people) :
            //his_skill = 0
            //for skill in p:
            //if skill in key:
            //his_skill |= 1 << key[skill]
            //for skill_set, need in dp.items():
            //with_him = skill_set | his_skill
            //if with_him == skill_set: continue
            //if with_him not in dp or len(dp[with_him]) > len(need) + 1:
            //dp[with_him] = need + [i]
            //return dp[(1 << n) - 1]
        }
    }
}
