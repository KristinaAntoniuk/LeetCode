namespace LeetCode
{
    public class RemoveDuplicatesFromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;

            int uniqueElements = nums.Length;

            for (int i = 0; i < uniqueElements; i++)
            {
                if (nums.SkipLast(nums.Length - i).Contains(nums[i]))
                {
                    for (int j = i; j < nums.Length - 1; j++)
                    {
                        nums[j] = nums[j + 1];
                    }

                    nums[uniqueElements - 1] = nums[i];
                    uniqueElements--;
                    i--;
                }
            }

            return uniqueElements;
        }

        public int RemoveDuplicatesSorting(int[] nums)
        {
            if (nums.Length == 0) return 0;

            Array.Sort(nums);

            int uniqueElements = nums.Length;

            for (int i = 0; i < uniqueElements - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    for (int j = i; j < nums.Length - 1; j++)
                    {
                        nums[j] = nums[j + 1];
                    }

                    nums[uniqueElements - 1] = nums[i];
                    uniqueElements--;
                    i--;
                }
            }

            return uniqueElements;
        }

        public int RemoveDuplicatesHashSet(int[] nums)
        {
            if (nums.Length == 0) return 0;

            HashSet<int> result = new HashSet<int>(nums);
            int[] resultArray = result.ToArray();

            int uniqueElements = result.Count;

            for (int i = 0; i < uniqueElements; i++)
            {
                nums[i] = resultArray[i];
            }
            Array.Copy(result.ToArray(), nums, uniqueElements);

            return uniqueElements;
        }

        public int RemoveDuplicatesII(int[] nums)
        {
            if (nums.Length == 0) return 0;

            int uniqueElements = nums.Length;

            for (int i = 0; i < uniqueElements - 2; i++)
            {
                if (nums[i] == nums[i + 1] && nums[i] == nums[i + 2])
                {
                    for (int j = i; j < nums.Length - 1; j++)
                    {
                        nums[j] = nums[j + 1];
                    }

                    uniqueElements--;
                    i--;
                }
            }

            return uniqueElements;
        }
    }
}
