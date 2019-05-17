using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        /// <summary>
        /// Satisfiability of Equality Equations (Do not Works)
        /// </summary>
        /// <param name="equations"></param>
        /// <returns></returns>
        public static bool EquationsPossible(string[] equations)
        {
            var equalDic = new ConcurrentDictionary<char, HashSet<char>>();
            var notEqualDic = new ConcurrentDictionary<char, HashSet<char>>();

            foreach (var equation in equations)
            {
                char first = equation[0], second = equation[3];
                if (equation[1] == '=')
                {
                    if (notEqualDic.ContainsKey(first) && notEqualDic[first].Contains(second))
                        return false;
                    EquationsPossibleAddOrUpdate(first, second, equalDic, true, notEqualDic.ContainsKey(first) ? notEqualDic[first] : null,
                        notEqualDic.ContainsKey(second) ? notEqualDic[second] : null);
                }
                else
                {
                    if (first == second || (equalDic.ContainsKey(first) && equalDic[first].Contains(second)))
                        return false;
                    EquationsPossibleAddOrUpdate(first, second, notEqualDic, true, equalDic.ContainsKey(first) ? equalDic[first] : null, 
                        equalDic.ContainsKey(second) ? equalDic[second] : null);
                }
            }

            return true;
        }

        public static void EquationsPossibleAddOrUpdate(char first, char second,
            ConcurrentDictionary<char, HashSet<char>> equalDic, bool root, HashSet<char> firstsSet = null,
            HashSet<char> secondsSet = null)
        {
            //Add first's neighbor second and first's neighbors second
            equalDic.AddOrUpdate(first, new HashSet<char>() {second}, (c, set) =>
            {
                if (root)
                {
                   var arr = equalDic[first].ToArray();
                    foreach (var ch in arr)
                        EquationsPossibleAddOrUpdate(ch, second, equalDic, false);
                }
                set.Add(second);

                return set;
            });
            if (secondsSet != null)
                foreach (var secondsChar in secondsSet)
                {
                    equalDic[first].Add(secondsChar);
                    equalDic.AddOrUpdate(secondsChar, new HashSet<char>() {first}, (c, set) =>
                    {
                        set.Add(first);
                        return set;
                    });
                }

            //Add second's neighbor first and second's neigbors firsts
            equalDic.AddOrUpdate(second, new HashSet<char>() {first}, (c, set) =>
            {
                if (root)
                {
                    var arr = equalDic[second].ToArray();
                    foreach (var ch in arr)
                        EquationsPossibleAddOrUpdate(ch, first, equalDic, false);
                }
                set.Add(first);

                return set;
            });

            if (firstsSet != null)
                foreach (var firstsChar in firstsSet)
                {
                    equalDic[second].Add(firstsChar);
                    equalDic.AddOrUpdate(firstsChar, new HashSet<char>() {second}, (c, set) =>
                    {
                        set.Add(second);
                        return set;
                    });
                }
        }

        /// <summary>
        /// Satisfiability of Equality Equations (Not mine)
        /// </summary>
        /// <param name="equations"></param>
        /// <returns></returns>
        public static bool EquationsPossible2(string[] equations)
        {
            int[] arr = new int[26].Select((_, i) => i).ToArray();
            foreach (var equation in equations)
                if (equation[1] == '=')
                    arr[EquationPossible2HelperFind(equation[0] - 'a', arr)] =
                        EquationPossible2HelperFind(equation[3] - 'a', arr);

            foreach (var equation in equations)
                if (equation[1] == '!' && EquationPossible2HelperFind(equation[0] - 'a', arr) ==
                    EquationPossible2HelperFind(equation[3] -
                                                'a', arr))
                    return false;

            return true;
        }

        private static int EquationPossible2HelperFind(int x, int[] arr)
        {
            if (x != arr[x])
                arr[x] = EquationPossible2HelperFind(arr[x], arr);
            return arr[x];
        }
    }
}
