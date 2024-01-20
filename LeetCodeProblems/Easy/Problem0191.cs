namespace LeetCodeProblems.Easy
{
    internal class Problem0191
    {
        public static int HammingWeight(int n)
        {
            return Convert.ToString(n, 2).Count(x => x == '1');
            
            // not my solution
            int ones = 0;
            while (n > 0)
            {
                ones += (int)(n & 1);
                n >>= 1;
            }

            return ones;
        }
    }
}
