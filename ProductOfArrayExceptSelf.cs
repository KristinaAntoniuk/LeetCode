namespace LeetCode
{
    public class ProductOfArrayExceptSelf
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] result = nums;
            int left = 1;
            int right = 1;

            for(int i = 0; i < nums.Length; i++)
            {
                result[i] = left;
                left *= nums[i];
            }

            for(int i = nums.Length - 1; i >= 0; i--)
            {
                result[i] *= right;
                right *= nums[i];
            }

            return result;
        }
    }
}
