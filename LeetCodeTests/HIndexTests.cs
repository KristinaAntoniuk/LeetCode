namespace LeetCodeTests
{
    [TestClass]
    public class HIndexTests
    {
        HIndex hIndex;
        public HIndexTests()
        {
            hIndex = new HIndex();
        }

        [TestMethod]
        public void TestMethod1()
        {
            int[] input = [3, 0, 6, 1, 5];
            Assert.AreEqual(3, hIndex.HIndexMethod(input));
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] input = [1,3,1];
            Assert.AreEqual(1, hIndex.HIndexMethod(input));
        }
    }
}
