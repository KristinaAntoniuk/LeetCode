namespace LeetCodeTests
{
    [TestClass]
    public class TrappingRainWaterTests
    {
        TrappingRainWater trappingRainWater;
        public TrappingRainWaterTests()
        {
            trappingRainWater = new TrappingRainWater();
        }

        [TestMethod]
        public void TestMethod1()
        {
            int[] input = [4, 2, 0, 3, 2, 5];
            Assert.AreEqual(9, trappingRainWater.Trap(input));
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] input = [2, 0, 4, 3, 0, 1];
            Assert.AreEqual(3, trappingRainWater.Trap(input));
        }
    }
}
