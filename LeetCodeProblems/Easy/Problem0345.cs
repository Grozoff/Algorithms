namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/reverse-vowels-of-a-string">Reverse Vowels of a String</see>
    /// <br>Two Pointers, String</br>
    /// </summary>
    internal class Problem0345
    {
        public string ReverseVowels(string s)
        {
            if (s.Length == 1) return s;

            var vowels = "AaEeIiOoUu";
            var p1 = 0;
            var p2 = s.Length - 1;
            var str = s.ToCharArray();
            while (p1 < p2)
            {
                if (vowels.Contains(str[p1]) && vowels.Contains(str[p2]))
                {
                    (str[p1], str[p2]) = (str[p2], str[p1]);
                    p1++;
                    p2--;
                    continue;
                }
                if (!vowels.Contains(str[p1]))
                {
                    p1++;
                    continue;
                }
                if (!vowels.Contains(str[p2]))
                {
                    p2--;
                    continue;
                }
            }

            return new string(str);
        }
    }
}
