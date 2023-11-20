namespace LeetCodeTests
{
    [TestClass]
    public class LongestPalindromicSubstringTests
    {
        LongestPalindromicSubstring longestPalindromicSubstring;
        public LongestPalindromicSubstringTests()
        {
            longestPalindromicSubstring = new LongestPalindromicSubstring();
        }

        [TestMethod]
        public void TestMethod1()
        {
            string s = "babad";
            string result = longestPalindromicSubstring.LongestPalindrome(s);
            string[] answers = ["bab", "aba"];
            Assert.IsTrue(answers.Contains(result));
        }

        [TestMethod]
        public void TestMethod2()
        {
            string s = "cbbd";
            string result = longestPalindromicSubstring.LongestPalindrome(s);
            string[] answers = ["bb"];
            Assert.IsTrue(answers.Contains(result));
        }

        [TestMethod]
        public void TestMethod3()
        {
            string s = "";
            string result = longestPalindromicSubstring.LongestPalindrome(s);
            string[] answers = [""];
            Assert.IsTrue(answers.Contains(result));
        }

        [TestMethod]
        public void TestMethod4()
        {
            string s = "civilwartestingwhetherthatnaptionoranynartionsoconceivedandsodedicatedcanlongendureWeareqmetonagreatbattlefiemldoftzhatwarWehavecometodedicpateaportionofthatfieldasafinalrestingplaceforthosewhoheregavetheirlivesthatthatnationmightliveItisaltogetherfangandproperthatweshoulddothisButinalargersensewecannotdedicatewecannotconsecratewecannothallowthisgroundThebravelmenlivinganddeadwhostruggledherehaveconsecrateditfaraboveourpoorponwertoaddordetractTgheworldadswfilllittlenotlenorlongrememberwhatwesayherebutitcanneverforgetwhattheydidhereItisforusthelivingrathertobededicatedheretotheulnfinishedworkwhichtheywhofoughtherehavethusfarsonoblyadvancedItisratherforustobeherededicatedtothegreattdafskremainingbeforeusthatfromthesehonoreddeadwetakeincreaseddevotiontothatcauseforwhichtheygavethelastpfullmeasureofdevotionthatweherehighlyresolvethatthesedeadshallnothavediedinvainthatthisnationunsderGodshallhaveanewbirthoffreedomandthatgovernmentofthepeoplebythepeopleforthepeopleshallnotperishfromtheearth";
            string result = longestPalindromicSubstring.LongestPalindrome(s);
            string[] answers = ["ranynar"];
            Assert.IsTrue(answers.Contains(result));
        }
    }
}