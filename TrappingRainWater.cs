namespace LeetCode
{
    public class TrappingRainWater
    {
        //O(N^2)

        //public int Trap(int[] height)
        //{
        //    int y = height.Max();
        //    int x = height.Length;

        //    int water = 0;
        //    for (int i = 0; i < y; i++)
        //    {
        //        int? start = null;

        //        for (int j = 0; j < x; j++)
        //        {
        //            if (height[j] >= i)
        //            {
        //                if (start == null) start = j;
        //                else
        //                {
        //                    water += j - start.Value - 1;
        //                    start = j;
        //                }
        //            }
        //        }
        //    }

        //    return water;
        //}


        //O(N)
        public int Trap(int[] height)
        {
            int maxIndex = 0;

            for(int i = 0; i < height.Length; i++)
            {
                if (height[i] > height[maxIndex])
                {
                    maxIndex = i;
                }
            }

            int water = 0;
            int left = 0;
            int right = height.Length - 2;
            int leftMax = height[0];
            int rightMax = height[height.Length - 1];

            while (left < maxIndex || right >= maxIndex)
            {
                if (left < maxIndex)
                {
                    int leftResult = leftMax - height[left];
                    if (leftResult >= 0)
                    {
                        water += leftResult;
                    }
                    else leftMax = height[left];
                    left++;
                }

                if (right >= maxIndex)
                {
                    int rightResult = rightMax - height[right];
                    if (rightResult >= 0)
                    {
                        water += rightResult;
                    }
                    else rightMax = height[right];
                    right--;
                }
            }

            return water;
        }

    }
}
