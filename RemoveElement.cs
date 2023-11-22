namespace LeetCode
{
    public class RemoveElement
    {
        public int RemoveElementMethod(int[] nums, int val)
        {
            if (nums.Length == 0) return 0;

            int remainingElements = nums.Length;

            for (int i = 0; i < remainingElements; i++)
            {
                if (nums[i] == val)
                {
                    for (int j = i; j < remainingElements - 1; j++)
                    {
                        nums[j] = nums[j + 1];
                    }
                    nums[remainingElements - 1] = val;
                    remainingElements--;
                    i--;
                }
            }

            return remainingElements;
        }
    }
}
