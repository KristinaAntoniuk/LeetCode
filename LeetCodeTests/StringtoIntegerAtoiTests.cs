namespace LeetCodeTests
{
    [TestClass]
    public class StringtoIntegerAtoiTests
    {
        StringtoIntegerAtoi stringtoIntegerAtoi;
        public StringtoIntegerAtoiTests()
        {
            stringtoIntegerAtoi = new StringtoIntegerAtoi();
        }

        [TestMethod]
        public void TestMethod1()
        {
            string s = "42";
            int result = stringtoIntegerAtoi.MyAtoi(s);
            Assert.AreEqual(42, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string s = "   -42";
            int result = stringtoIntegerAtoi.MyAtoi(s);
            Assert.AreEqual(-42, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string s = "4193 with words";
            int result = stringtoIntegerAtoi.MyAtoi(s);
            Assert.AreEqual(4193, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string s = "-34583928397459283495798374";
            int result = stringtoIntegerAtoi.MyAtoi(s);
            Assert.AreEqual(Int32.MinValue, result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            string s = "+-12";
            int result = stringtoIntegerAtoi.MyAtoi(s);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestMethod6()
        {
            string s = "00000-42a1234";
            int result = stringtoIntegerAtoi.MyAtoi(s);
            Assert.AreEqual(0, result);
        }
    }
}
