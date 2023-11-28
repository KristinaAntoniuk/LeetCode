namespace LeetCode
{
    public class GasStation
    {
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            int sumGas = 0;
            int sumCost = 0;
            int total = 0;
            int index = 0;

            for (int i = 0; i < gas.Length; i++)
            {
                sumGas += gas[i];
                sumCost += cost[i];
                total += (gas[i] - cost[i]);

                if (total < 0)
                {
                    total = 0;
                    index = i + 1;
                }
            }

            if (sumGas >= sumCost)
            {
                return index;
            }
            else return -1;
        }
    }
}
