namespace LeetCodeTests
{
    [TestClass]
    public class GasStationTests
    {
        GasStation gasStation;
        public GasStationTests()
        {
            gasStation = new GasStation();
        }

        [TestMethod]
        public void TestMethod1()
        {
            int[] gas = [2, 3, 4];
            int[] cost = [3, 4, 3];
            Assert.AreEqual(-1, gasStation.CanCompleteCircuit(gas, cost));
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] gas = [1, 2, 3, 4, 5];
            int[] cost = [3, 4, 5, 1, 2];
            Assert.AreEqual(3, gasStation.CanCompleteCircuit(gas, cost));
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] gas = [3, 1, 1];
            int[] cost = [1, 2, 2];
            Assert.AreEqual(0, gasStation.CanCompleteCircuit(gas, cost));
        }
    }
}
