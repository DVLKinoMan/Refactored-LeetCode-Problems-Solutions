using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LC_Problems.Tests
{
    [TestClass]
    public class StoneGameIITester
    {
        [TestMethod]
        public void Method1()
        {
            int d = StoneGameII(new int[] { 2, 7, 9, 4, 4 });
            //CircularPermutation(2, 3);
            //MinRemoveToMakeValid("lee(t(c)o)de)");
            //ReconstructMatrix(9, 2, new int[] {0, 1, 2, 0, 0, 0, 0, 0, 2, 1, 2, 1, 2});
            MaxScoreWords(new String[] {"dog", "cat", "dad", "good"}
                , new char[] {'a', 'a', 'c', 'd', 'd', 'd', 'g', 'o', 'o'},
                new int[] {1, 0, 9, 5, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0});

            Assert.AreEqual(10, d);
        }
    }
}
