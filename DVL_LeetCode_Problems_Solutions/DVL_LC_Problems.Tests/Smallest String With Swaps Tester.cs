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
    public class Smallest_String_With_Swaps_Tester
    {
        [TestMethod]
        public void TestMethod1()
        {
            var list = new List<IList<int>>(){
                                        new List<int>(){3, 3 },
                                        new List<int>(){3, 0 },
                                        new List<int>(){5, 1},
                                        new List<int>(){3, 1},
                                        new List<int>(){3, 4 },
                                        new List<int>(){3, 5 }
            };
            SmallestStringWithSwaps("udyyek", list);
        }
    }
}
