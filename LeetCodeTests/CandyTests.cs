namespace LeetCodeTests
{
    [TestClass]
    public class CandyTests
    {
        Candy candy;
        public CandyTests()
        {
            candy = new Candy();
        }

        [TestMethod] 
        public void TestMethod1() 
        {
            int[] ratings = [1, 0, 2];
            Assert.AreEqual(5, candy.CandyMethod(ratings));
        }
    }
}
