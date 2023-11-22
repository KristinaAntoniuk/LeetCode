namespace LeetCode
{
    public class MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int[] result = new int[nums1.Length];
            Array.Copy(nums1, result, m);
            Array.Copy(nums2, 0, result, m, n);
            Array.Sort(result);
            Array.Copy(result, nums1, result.Length);
        }
    }
}
