using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests
{
    [TestClass]
    public class MergeSortedArrayTests
    {
        MergeSortedArray mergeSortedArray;
        public MergeSortedArrayTests()
        {
            mergeSortedArray = new MergeSortedArray();
        }

        [TestMethod]
        public void TestMethod1()
        {
            int[] nums1 = [1, 2, 3, 0, 0, 0];
            int[] nums2 = [2, 5, 6];
            int[] result = [1, 2, 2, 3, 5, 6];
            int m = 3;
            int n = 3;
            mergeSortedArray.Merge(nums1, m, nums2, n);
            CollectionAssert.AreEqual(result, nums1);
        }
    }
}
