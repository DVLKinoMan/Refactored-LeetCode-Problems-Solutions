using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        public static IList<IList<string>> AccountsMerge(IList<IList<string>> accounts)
        {
            var emailIndexesList = new Dictionary<string, List<int>>();
            var unionSets = new Dictionary<int, List<int>>();
            var mapper = new Dictionary<int, int>();
            for (int i = 0; i < accounts.Count; i++)
            for (int j = 1; j < accounts[i].Count; j++)
            {
                if (emailIndexesList.ContainsKey(accounts[i][j]))
                    emailIndexesList[accounts[i][j]].Add(i);
                else emailIndexesList.Add(accounts[i][j], new List<int>() {i});
            }

            foreach (var emailIndexes in emailIndexesList)
            {
                int emailIndex = -1;
                foreach (var emIndex in 
                    emailIndexes.Value.Where(emIndex => unionSets.ContainsKey(emIndex) || mapper.ContainsKey(emIndex)))
                {
                    emailIndex = emIndex;
                    break;
                }

                if (unionSets.ContainsKey(emailIndex))
                {
                    foreach (var ind in emailIndexes.Value)
                    {
                        unionSets[emailIndex].Add(ind);
                        if(!mapper.ContainsKey(ind))
                            mapper.Add(ind, emailIndex);
                    }
                }
                else if (mapper.ContainsKey(emailIndex))
                {
                    int parentIndex = GetRoot(emailIndex, mapper);
                    foreach (var ind in emailIndexes.Value)
                    {
                        unionSets[parentIndex].Add(ind);
                        if (!mapper.ContainsKey(ind))
                            mapper.Add(ind, parentIndex);
                    }
                }
                else
                {
                    int f = emailIndexes.Value.First();
                    unionSets.Add(f, emailIndexes.Value);
                    foreach (var i in emailIndexes.Value.Skip(1))
                        if (!mapper.ContainsKey(i))
                            mapper.Add(i, f);
                }
            }

            var res = new List<IList<string>>();
            foreach (var d in unionSets)
            {
                var list = d.Value.SelectMany(i => accounts[i].Skip(1)).Distinct().OrderBy(em => em, StringComparer.Ordinal).ToList();
                list.Insert(0, accounts[d.Value.First()][0]);
                res.Add(list);
            }

            return res;

            static int GetRoot(int ind, Dictionary<int, int> map)
            {
                int res = map[ind];
                while (map.ContainsKey(res))
                    res = map[res];
                return res;
            }
        }
    }
}
