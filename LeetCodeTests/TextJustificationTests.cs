namespace LeetCodeTests
{
    [TestClass]
    public class TextJustificationTests
    {
        TextJustification textJustification;
        public TextJustificationTests()
        {
            textJustification = new TextJustification();
        }

        [TestMethod]
        public void TestMethod1()
        {
            string[] words = ["This", "is", "an", "example", "of", "text", "justification."];
            int maxWidth = 16;
            List<string> result = [
                "This    is    an",
                "example  of text",
                "justification.  "
            ];
            CollectionAssert.AreEqual(result, textJustification.FullJustify(words, maxWidth).ToList());
        }

        [TestMethod]
        public void TestMethod2()
        {
            string[] words = ["What", "must", "be", "acknowledgment", "shall", "be"];
            int maxWidth = 16;
            string[] result = [
                "What   must   be",
                "acknowledgment  ",
                "shall be        "
            ];
            CollectionAssert.AreEqual(result, textJustification.FullJustify(words, maxWidth).ToList());
        }

        [TestMethod]
        public void TestMethod3()
        {
            string[] words = ["Science", "is", "what", "we", "understand", "well", "enough", "to", "explain", "to", "a", "computer.", "Art", "is", "everything", "else", "we", "do"];
            int maxWidth = 20;
            string[] result = [
                "Science  is  what we",
                "understand      well",
                "enough to explain to",
                "a  computer.  Art is",
                "everything  else  we",
                "do                  "
            ];
            CollectionAssert.AreEqual(result, textJustification.FullJustify(words, maxWidth).ToList());
        }

        [TestMethod]
        public void TestMethod4()
        {
            string[] words = ["My", "momma", "always", "said,", "\"Life", "was", "like", "a", "box", "of", "chocolates.", "You", "never", "know", "what", "you're", "gonna", "get."];
            int maxWidth = 20;
            //string[] result = [
            //    "My    momma   always", 
            //    "said, \"Life was like", 
            //    "a box of chocolates.", 
            //    "You  never know what", 
            //    "you're gonna get."];
            string[] result = [
                "My    momma   always",
                "said, \"Life was like",
                "a box of chocolates.",
                "You  never know what",
                "you're gonna get.   "];
            CollectionAssert.AreEqual(result, textJustification.FullJustify(words, maxWidth).ToList());
        }
    }
}
