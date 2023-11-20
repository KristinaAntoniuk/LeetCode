namespace LeetCodeTests
{
    [TestClass]
    public class ReverseIntegerTests
    {
        ReverseInteger reverseInteger;
        public ReverseIntegerTests()
        {
            reverseInteger = new ReverseInteger();
        }

        [TestMethod]
        public void TestMethod1()
        {
            int x = 123;
            int result = reverseInteger.Reverse(x);
            Assert.AreEqual(321, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int x = 0;
            int result = reverseInteger.Reverse(x);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int x = 901000;
            int result = reverseInteger.Reverse(x);
            Assert.AreEqual(109, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int x = -2147483648;
            int result = reverseInteger.Reverse(x);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            int x = 1534236469;
            int result = reverseInteger.Reverse(x);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestMethod6()
        {
            int x = -123;
            int result = reverseInteger.Reverse(x);
            Assert.AreEqual(-321, result);
        }
    }
}
