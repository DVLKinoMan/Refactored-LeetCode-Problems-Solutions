using System;
using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Accounts Merge (Mine)
        /// </summary>
        /// <param name="accounts"></param>
        /// <returns></returns>
        public static IList<IList<string>> AccountsMerge(IList<IList<string>> accounts)
        {
            var parents = new Dictionary<string, string>();
            var emailOwners = new Dictionary<string, string>();
            foreach (var account in accounts)
            {
                if (!emailOwners.ContainsKey(account[1]))
                    emailOwners.Add(account[1], account[0]);

                var setOfRoots = new HashSet<string>();
                var notHaveParents = new HashSet<string>();
                foreach (var em in account.Skip(1))
                {
                    if (parents.ContainsKey(em))
                        setOfRoots.Add(FindRoot(em, parents));
                    else notHaveParents.Add(em);
                }

                if (setOfRoots.Count != 0)
                {
                    string parent = setOfRoots.First();
                    foreach (var notHaveParent in notHaveParents)
                        parents.Add(notHaveParent, parent);

                    foreach (var root in setOfRoots)
                        parents[root] = parent;
                }
                else
                {
                    parents.Add(account[1], account[1]);
                    foreach (var em in account.Skip(2))
                        if (!parents.ContainsKey(em))
                            parents.Add(em, account[1]);
                }
            }

            var res = parents.GroupBy(p => FindRoot(p.Value, parents)).Select(gr =>
            {
                IList<string> list = gr.Select(g => g.Key).OrderBy(em=>em, StringComparer.Ordinal).ToList();
                list.Insert(0, emailOwners[gr.Key]);
                return list;
            }).ToList();

            return res;

            string FindRoot(string em, Dictionary<string, string> mapper) =>
                mapper[em] == em ? em : FindRoot(mapper[em], mapper);
        }
    }
}
