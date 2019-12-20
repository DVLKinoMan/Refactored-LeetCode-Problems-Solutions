using Microsoft.VisualStudio.TestTools.UnitTesting;

using static DVL_LeetCode_Problems_Solutions.Domain.ProblemSolver;

namespace DVL_LC_Problems.Tests
{
    /// <summary>
    /// Summary description for Broken_Calculator
    /// </summary>
    [TestClass]
    public class BrokenCalculator
    {
        public BrokenCalculator()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod1()
        {
            int answer = BrokenCalc(2, 3);
            Assert.AreEqual(2, answer);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int answer = BrokenCalc(5, 8);
            Assert.AreEqual(2, answer);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int answer = BrokenCalc(3,10);
            Assert.AreEqual(3, answer);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int answer = BrokenCalc(1024, 1);
            Assert.AreEqual(1023, answer);
        }

        [TestMethod]
        public void TestMethod5()
        {
            int answer = BrokenCalc(8, 10);
            Assert.AreEqual(4, answer);
        }
    }
}
