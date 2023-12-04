namespace LeetCodeTests
{
    [TestClass]
    public class ReverseWordsInAStringTests
    {
        ReverseWordsInAString reverseWordsInAString;

        public ReverseWordsInAStringTests()
        {
            reverseWordsInAString = new ReverseWordsInAString();
        }

        [TestMethod]
        public void TestMethod1()
        {
            string s = "the sky is blue";
            Assert.AreEqual("blue is sky the", reverseWordsInAString.ReverseWords(s));
        }

        [TestMethod]
        public void TestMethod2()
        {
            string s = "a good   example";
            Assert.AreEqual("example good a", reverseWordsInAString.ReverseWords(s));
        }
    }
}
