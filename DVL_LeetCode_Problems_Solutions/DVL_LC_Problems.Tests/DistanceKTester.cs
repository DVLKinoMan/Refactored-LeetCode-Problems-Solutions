using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using NUnit.Framework;
using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LC_Problems.Tests
{
    [TestFixture]
    public class DistanceKTester
    {
        [Test]
        public void TestMethod1()
        {
            var target =
                new TreeNode(5)
                {
                    left = new TreeNode(6),
                    right = new TreeNode(2)
                    {
                        left = new TreeNode(7),
                        right = new TreeNode(4)
                    }
                };
            
            var root = new TreeNode(3)
            {
                left = target,
                right = new TreeNode(1)
                {
                    left = new TreeNode(0),
                    right = new TreeNode(8)
                }
            };
            
            DistanceK(root, target, 2);
        }

        [Test]
        public void TestMethod2()
        {
            var target = new TreeNode(2);
            
            var root = new TreeNode(0)
            {
                left = new TreeNode(1)
                {
                    left = new TreeNode(3),
                    right = target
                },
            };
            
            DistanceK(root, target, 1);
        }

        [Test]
        public void TestMethod3()
        {   
            var target = new TreeNode(5)
            {
                left = new TreeNode(6),
                right = new TreeNode(2)
                {
                    left = new TreeNode(7),
                    right = new TreeNode(4)
                }
            };
            
            var root = new TreeNode(3)
            {
                left = target,
                right = new TreeNode(1)
                {
                    left = new TreeNode(0),
                    right = new TreeNode(8)
                }
            };
            
            DistanceK(root, target, 2);
        }
    }
}