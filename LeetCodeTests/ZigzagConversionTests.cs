namespace LeetCodeTests
{
    [TestClass]
    public class ZigzagConversionTests
    {
        ZigzagConversion zigzagConversion;
        public ZigzagConversionTests()
        {
                zigzagConversion = new ZigzagConversion();
        }

        [TestMethod]
        public void TestMethod1()
        {
            string s = "PAYPALISHIRING";
            int numRows = 3;
            Assert.AreEqual("PAHNAPLSIIGYIR", zigzagConversion.ConvertI(s, numRows));
        }

        [TestMethod]
        public void TestMethod2()
        {
            string s = "PAYPALISHIRING";
            int numRows = 4;
            Assert.AreEqual("PINALSIGYAHRPI", zigzagConversion.ConvertII(s, numRows));
        }
    }
}
