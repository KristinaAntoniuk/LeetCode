namespace LeetCodeTests
{
    [TestClass]
    public class RotateArrayTests
    {
        private RotateArray rotateArray;

        public RotateArrayTests()
        {
            rotateArray = new RotateArray();
        }

        [TestMethod]
        public void TestMethod1()
        {
            int[] nums = [1, 2, 3, 4, 5, 6, 7];
            int k = 3;
            int[] result = [5, 6, 7, 1, 2, 3, 4];
            rotateArray.Rotate(nums, k);
            CollectionAssert.AreEqual(result, nums);
        }
    }
}
