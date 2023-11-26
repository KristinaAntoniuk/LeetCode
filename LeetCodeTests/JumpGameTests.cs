namespace LeetCodeTests
{
    [TestClass]
    public class JumpGameTests
    {
        JumpGame jumpGame;

        public JumpGameTests()
        {
            jumpGame = new JumpGame();
        }

        [TestMethod]
        public void TestMethod1()
        {
            int[] array = [2, 3, 1, 1, 4];
            Assert.IsTrue(jumpGame.CanJump(array));
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] array = [3, 2, 1, 0, 4];
            Assert.IsFalse(jumpGame.CanJump(array));
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] array = [2, 0];
            Assert.IsTrue(jumpGame.CanJump(array));
        }

        [TestMethod]
        public void TestMethod4()
        {
            int[] array = [1, 1, 1, 0];
            Assert.IsTrue(jumpGame.CanJump(array));
        }

        [TestMethod]
        public void TestMethod5()
        {
            int[] array = [1, 1, 2, 2, 0, 1, 1];
            Assert.IsTrue(jumpGame.CanJump(array));
        }

        [TestMethod]
        public void TestMethod6()
        {
            int[] array = [5, 9, 3, 2, 1, 0, 2, 3, 3, 1, 0, 0];
            Assert.IsTrue(jumpGame.CanJump(array));
        }

        [TestMethod]
        public void TestMethod7()
        {
            int[] array = [2, 3, 1, 1, 4];
            Assert.AreEqual(2, jumpGame.CanJumpII(array));
        }

    }
}
