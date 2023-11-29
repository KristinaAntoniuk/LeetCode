namespace LeetCode
{
    public class Candy
    {
        public int CandyMethod(int[] ratings)
        {
            int amount = ratings.Length;
            int[] addons = new int[amount];

            for (int i = 0; i < amount - 1; i++)
            {
                if (ratings[i] < ratings[i + 1] &&
                    addons[i] >= addons[i + 1])
                {
                    addons[i + 1] = addons[i] + 1;
                }
            }

            for (int i = amount - 1; i > 0; i--)
            {
                if (ratings[i] < ratings[i - 1] &&
                    addons[i] >= addons[i - 1])
                {
                    addons[i - 1] = addons[i] + 1;
                }
            }

            return amount + addons.Sum();
        }
    }
}
