namespace LeetCodeProblems.Easy
{
    internal class Problem0326
    {
        public bool IsPowerOfThree(int n)
        {
            // We only need to see if the largest power of 3 is divisible by n.Since the input is an Int32, the largest allowed power of 3 is 3 ^ 19.
            var maxPow = (int)Math.Pow(3, 19);

            return n > 0 && maxPow % n == 0;
        }
    }
}
