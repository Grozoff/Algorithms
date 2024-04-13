namespace LeetCodeProblems.Hard
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/trapping-rain-water/">Trapping Rain Water</see>
    /// <br>Array, Two Pointers, Dynamic Programming, Stack, Monotonic Stack</br>
    /// </summary>
    internal class Problem0042
    {
        public int Trap(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;
            int ans = 0;
            int leftMax = 0;
            int rightMax = 0;
            while (left < right)
            {
                if (height[left] < height[right])
                {
                    if (height[left] >= leftMax)
                    {
                        leftMax = height[left];
                    }
                    else
                    {
                        ans += (leftMax - height[left]);
                    }
                    left++;
                }
                else
                {
                    if (height[right] >= rightMax)
                    {
                        rightMax = height[right];
                    }
                    else
                    {
                        ans += (rightMax - height[right]);
                    }
                    right--;
                }
            }
            return ans;
        }
    }
}
