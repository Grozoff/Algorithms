namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/reverse-bits/">Reverse Bits</see>
    /// <br>Divide and Conquer, Bit Manipulation</br>
    /// </summary>
    internal class Problem0190
    {
        public uint reverseBits(uint n)
        {
            var bits = Convert.ToString(n, 2).PadLeft(32, '0').ToCharArray();
            Array.Reverse(bits);

            return Convert.ToUInt32(new string(bits), 2);
        }
    }
}
