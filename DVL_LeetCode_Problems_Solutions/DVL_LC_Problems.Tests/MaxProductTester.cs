using DVL_LeetCode_Problems_Solutions.Domain.Classes;
using Moq;
using NUnit.Framework;
using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LC_Problems.Tests
{
    public interface ILog
    {
        string Log(string message);
    }
    
    [TestFixture]
    public class MaxProductTester
    {
        [Test]
        public void TestOnLittleExample()
        {
            int product = MaxProduct(new TreeNode(4)
            {
                left = new TreeNode(2),
                right = new TreeNode(5)
                {
                    left = new TreeNode(9),
                    right = new TreeNode(19)
                }
            });
            
            Assert.That(product, Is.EqualTo(380));
        }

        [Test]
        public void TestWithMoq()
        {
            var moq = new Mock<ILog>();
            moq.Setup(log => log.Log(It.Is<string>(str => str.Length % 2 == 0))).Returns("HasEvenLength");
            moq.Setup(log => log.Log(It.Is<string>(str => str.Length % 2 == 1))).Returns("HasOddLength");
            Assert.Multiple(
                () =>
                {
                    Assert.That(moq.Object.Log("aba"), Is.EqualTo("HasOddLength"));
                    Assert.That(moq.Object.Log("abde"), Is.Not.EqualTo("HasOddLength"));
                    Assert.That(moq.Object.Log("abde"), Is.EqualTo("HasEvenLength"));
                }
            );
        }
    }
}