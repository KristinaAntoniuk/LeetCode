using System.Runtime.InteropServices.JavaScript;

namespace LeetCode
{
    public class JumpGame
    {
        public bool CanJump(int[] nums)
        {
            if (nums.Length == 0) return false;

            int lastIndex = nums.Length - 1;

            for (int i = lastIndex; i >= 0; i--)
            {
                if (i + nums[i] >= lastIndex)
                {
                    if (i == 0) return true;

                    lastIndex = i;
                }
            }

            return false;
        }

        public int CanJumpII(int[] nums)
        {
            if (nums.Length == 0) return 0;

            int lastIndex = nums.Length - 1;
            int jumps = 0;


            for (int i = lastIndex; i >= 0; i--)
            {
                int? max = null;

                for (int j = i; j >= 0; j--)
                {
                    if (j + nums[j] >= lastIndex)
                    {
                        max = j;
                    }
                }

                if (max != null)
                {
                    lastIndex = max.Value;
                    i = lastIndex;
                    jumps++;
                }
            }

            return jumps;
        }
    }
}
