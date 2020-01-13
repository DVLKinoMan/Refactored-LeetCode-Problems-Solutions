using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Number of Operations to Make Network Connected (Not Implemented)
        /// </summary>
        /// <param name="n"></param>
        /// <param name="connections"></param>
        /// <returns></returns>
        public static int MakeConnected(int n, int[][] connections)
        {
            var dict = new Dictionary<int, int>();
            int extra = 0, lastIndex = 0;
            foreach (var connection in connections)
            {
                int a = connection[0], b = connection[1];
                if (dict.ContainsKey(a))
                {
                    if (dict.ContainsKey(b))
                    {
                        if (dict[a] == dict[b])
                            extra++;
                        else
                        {
                            int val = dict[b];
                            foreach (var item in dict.Where(k => k.Value == val))
                                dict[item.Key] = dict[a];
                        }
                    }
                    else
                        dict.Add(b, dict[a]);
                }
                else
                {
                    if (dict.ContainsKey(b))
                    {
                        if (dict.ContainsKey(a))
                        {
                            if (dict[a] == dict[b])
                                extra++;
                            else
                            {
                                int val = dict[a];
                                var l = dict.Where(k => k.Value == val).ToList();
                                foreach (var item in l)
                                    dict[item.Key] = dict[b];
                            }
                        }
                        else
                            dict.Add(a, dict[b]);
                    }
                    else
                    {
                        dict.Add(a, lastIndex);
                        dict.Add(b, lastIndex);
                        lastIndex++;
                    }
                }
            }

            int prevExtra = extra;
            for (int i = 1; i < n; i++)
                if (!dict.ContainsKey(i))
                {
                    if (extra > 0)
                        extra--;
                    else return -1;
                }

            return prevExtra - extra;
        }
    }
}
