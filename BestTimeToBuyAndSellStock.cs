namespace LeetCode
{
    public class BestTimeToBuyAndSellStock
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length == 0) return 0;

            int min = prices[0];
            int maxProfit = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < min)
                {
                    min = prices[i];
                }
                else
                {
                    int profit = prices[i] - min;
                    if (profit > maxProfit)
                    {
                        maxProfit = profit;
                    }
                }
            }

            return maxProfit;
        }

        public int MaxProfitII(int[] prices)
        {
            if (prices.Length == 0) return 0;

            int min = prices[0];
            int profit = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < min)
                {
                    min = prices[i];
                }
                else
                {
                    if (i == prices.Length - 1) 
                    {
                        if (prices[i] > min)
                        {
                            profit += prices[i] - min;
                        }
                    }
                    else if (prices[i + 1] < prices[i])
                    {
                        profit += prices[i] - min;
                        min = prices[i + 1];
                        i++;
                    }
                }
            }

            return profit;
        }
    }
}
