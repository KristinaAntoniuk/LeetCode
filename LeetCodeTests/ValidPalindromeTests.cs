namespace LeetCodeTests
{
    [TestClass]
    public class ValidPalindromeTests
    {
        ValidPalindrome isPalindrome;

        public ValidPalindromeTests()
        {
            isPalindrome = new ValidPalindrome();
        }

        [TestMethod]
        public void TestMethod1()
        {
            string input = "A man, a plan, a canal: Panama";
            Assert.AreEqual(true, isPalindrome.IsPalindrome(input));
        }
    }
}
