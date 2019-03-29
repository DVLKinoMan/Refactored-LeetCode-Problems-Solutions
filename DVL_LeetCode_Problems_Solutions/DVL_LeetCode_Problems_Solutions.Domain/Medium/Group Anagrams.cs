using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var dic=new Dictionary<string, List<string>>();
            foreach (var str in strs)
            {
                var strSorted = string.Concat(str.OrderBy(s => s));
                if (dic.ContainsKey(strSorted))
                    dic[strSorted].Add(str);
                else dic.Add(strSorted, new List<string> { str });
            }

            var result = new List<IList<string>>();
            foreach (var d in dic)
                result.Add(d.Value);

            return result;
        }

        //Deprecated
        //private static int GetUniqueCodeForString(string str)
        //{
        //    int unique = 0;
        //    foreach (var ch in str)
        //        unique += (int) Math.Pow(2, ch - 'a');
        //    return unique;
        //}
    }
}
