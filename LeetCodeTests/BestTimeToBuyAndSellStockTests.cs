namespace LeetCodeTests
{
    [TestClass]
    public class BestTimeToBuyAndSellStockTests
    {
        BestTimeToBuyAndSellStock bestTimeToBuyAndSellStock;

        public BestTimeToBuyAndSellStockTests()
        {
            bestTimeToBuyAndSellStock = new BestTimeToBuyAndSellStock();
        }

        [TestMethod]
        public void TestMethod1()
        {
            int[] input = [7, 1, 5, 3, 8, 4, 2, 10];
            int result = 17;
            Assert.AreEqual(result, bestTimeToBuyAndSellStock.MaxProfitII(input));
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] input = [3, 3];
            int result = 0;
            Assert.AreEqual(result, bestTimeToBuyAndSellStock.MaxProfitII(input));
        }
    }
}
