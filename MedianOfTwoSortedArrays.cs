namespace LeetCode
{
    internal class MedianOfTwoSortedArrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            double result = 0;
            int[] merged = nums1.Concat(nums2).ToArray();
            Array.Sort(merged);

            if (merged.Length % 2 == 0)
            {
                return result = (Convert.ToDouble(merged[merged.Length / 2]) +
                                Convert.ToDouble(merged[(merged.Length / 2 - 1)])) / 2;
            }
            else
            {
                return result = Convert.ToDouble(merged[merged.Length / 2]);
            }
        }
    }
}
