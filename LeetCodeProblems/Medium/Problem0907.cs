namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/sum-of-subarray-minimums">Sum of Subarray Minimums</see>
    /// <br>Array, Dynamic Programming, Stack, Monotonic Stack</br>
    /// </summary>
    internal class Problem0907
    {
        public int SumSubarrayMins(int[] arr)
        {
            // not my solution
            long sum = 0;
            var stack = new Stack<int>();

            for (int i = 0; i <= arr.Length; i++)
            {
                while (stack.Count > 0 && arr[stack.Peek()] > (i == arr.Length ? int.MinValue : arr[i]))
                {
                    int mid = stack.Pop();
                    int left = stack.Count == 0 ? -1 : stack.Peek();
                    int right = i;
                    sum += (long)(arr[mid]) * (mid - left) * (right - mid);
                }
                stack.Push(i);
            }

            return (int)(sum % 1000000007);
        }
    }
}
