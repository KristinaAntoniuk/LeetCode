namespace LeetCode
{
    internal class MajorityElement
    {
        public int MajorityElementMethod(int[] nums)
        {

            Array.Sort(nums);
            int minApp = nums.Length / 2 + 1;

            for (int i = 0; i <= nums.Length - minApp; i++)
            {
                bool majority = true;
                for (int j = i + 1; j < i + minApp; j++)
                {
                    if (nums[i] != nums[j])
                    {
                        majority = false;
                        i = j - 1;
                        break;
                    }
                }

                if (majority) return nums[i];
            }

            return 0;
        }
    }
}
