using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests
{
    [TestClass]
    public class RemoveElementTests
    {
        RemoveElement removeElement;
        public RemoveElementTests()
        {
            removeElement = new RemoveElement();
        }

        [TestMethod]
        public void TestMethod1()
        {
            int[] nums = [2];
            int val = 3;
            int result = removeElement.RemoveElementMethod(nums, val);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] nums = [3, 2, 2, 3];
            int val = 3;
            int result = removeElement.RemoveElementMethod(nums, val);
            Assert.AreEqual(2, result);
        }
    }
}
