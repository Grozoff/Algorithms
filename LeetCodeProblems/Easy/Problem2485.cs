namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/find-the-pivot-integer'>Find the Pivot Integer</see>
    /// <br>Math, Prefix Sum</br>
    /// </summary>
    internal class Problem2485
    {
        public int PivotInteger(int n)
        {
            // bruit force solution
            var sum = 0;
            for (int i = 1; i < n + 1; i++)
            {
                sum += i;
            }
            var temp = 0;
            for (int i = 1; i < n + 1; i++)
            {
                sum -= i;
                if (sum == temp)
                {
                    return i;
                }
                temp += i;
            }

            return -1;

            // math solution
            var sum1 = (n * (n + 1) / 2);
            var pivot = (int)Math.Sqrt(sum);
            // If pivot * pivot is equal to sum (pivot found) return pivot, else return -1
            return pivot * pivot == sum ? pivot : -1;
        }
    }
}
