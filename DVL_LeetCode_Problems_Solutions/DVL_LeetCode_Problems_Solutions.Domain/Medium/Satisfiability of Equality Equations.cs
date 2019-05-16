using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        public static bool EquationsPossible(string[] equations)
        {
            var equalDic=new ConcurrentDictionary<char,HashSet<char>>();
            var notEqualDic=new ConcurrentDictionary<char, HashSet<char>>();

            foreach (var equation in equations)
            {
                char first = equation[0], second = equation[3];
                if (equation[1] == '=')
                {
                    if (notEqualDic.ContainsKey(first) && notEqualDic[first].Contains(second))
                        return false;
                    EquationsPossibleAddOrUpdate(first, second, equalDic, true);
                }
                else
                {
                    if (equalDic.ContainsKey(first) && equalDic[first].Contains(second))
                        return false;
                    EquationsPossibleAddOrUpdate(first, second, notEqualDic, true);
                }
            }

            return true;
        }

        public static void EquationsPossibleAddOrUpdate(char first, char second,
            ConcurrentDictionary<char, HashSet<char>> equalDic, bool root)
        {
            equalDic.AddOrUpdate(first, new HashSet<char>() { second }, (c, set) =>
            {
                if (root)
                    foreach (var ch in equalDic[first])
                        EquationsPossibleAddOrUpdate(ch, second, equalDic, false);
                equalDic[first].Add(second);

                return equalDic[first];
            });

            equalDic.AddOrUpdate(second, new HashSet<char>() { first }, (c, set) =>
            {
                if (root)
                    foreach (var ch in equalDic[second])
                        EquationsPossibleAddOrUpdate(ch, first, equalDic, false);
                equalDic[second].Add(first);

                return equalDic[second];
            });
        }
    }
}
