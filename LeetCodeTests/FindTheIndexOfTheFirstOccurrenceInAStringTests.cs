namespace LeetCodeTests
{
    [TestClass]
    public class FindTheIndexOfTheFirstOccurrenceInAStringTests
    {
        FindTheIndexOfTheFirstOccurrenceInAString findTheIndexOfTheFirstOccurrenceInAString;

        public FindTheIndexOfTheFirstOccurrenceInAStringTests()
        {
            findTheIndexOfTheFirstOccurrenceInAString = new FindTheIndexOfTheFirstOccurrenceInAString();
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0, findTheIndexOfTheFirstOccurrenceInAString.StrStr("a", "a"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(4, findTheIndexOfTheFirstOccurrenceInAString.StrStr("mississippi", "issip"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(-1, findTheIndexOfTheFirstOccurrenceInAString.StrStr("leetcode", "leeto"));
        }
    }
}
