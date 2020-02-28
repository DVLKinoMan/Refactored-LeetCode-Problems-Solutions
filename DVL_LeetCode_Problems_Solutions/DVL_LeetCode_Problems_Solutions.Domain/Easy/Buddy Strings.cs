using System.Collections.Generic;
using System.Linq;

namespace DVL_LeetCode_Problems_Solutions.Domain
{
    partial class ProblemSolver
    {
        public static bool BuddyStrings(string A, string B)
        {
            if (A.Length != B.Length)
                return false;
            
            var notEqual1= new HashSet<char>();
            var notEqual2=new HashSet<char>();
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] != B[i])
                {
                    if (notEqual1.Count > 2)
                        return false;
                    notEqual1.Add(A[i]);
                    notEqual2.Add(B[i]);
                }
            }

            return (notEqual1.Count == 0 && A.Distinct().Count() != A.Length) ||
                   notEqual1.All(not => notEqual2.Contains(not));
        }
    }
}