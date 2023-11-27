using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetCode.InsertDeleteGetRandomO1;

namespace LeetCodeTests
{
    [TestClass]
    public class InsertDeleteGetRandomO1Tests
    {
        InsertDeleteGetRandomO1 insertDeleteGetRandomO1;
        public InsertDeleteGetRandomO1Tests()
        {
            insertDeleteGetRandomO1 = new InsertDeleteGetRandomO1();
        }

        [TestMethod]
        public void TestMethod1()
        {
            RandomizedSet randomizedSet = new RandomizedSet();
            randomizedSet.Insert(1);
            randomizedSet.Insert(10);
            randomizedSet.Insert(20);
            randomizedSet.Insert(30);
            int random = randomizedSet.GetRandom();
        }
    }
}
