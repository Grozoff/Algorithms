namespace LeetCodeProblems.Hard
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/minimum-window-substring">Minimum Window Substring</see>
    /// <br>Hash Table, String, Sliding Window</br>
    /// </summary>
    internal class Problem0076
    {
        public string MinWindow(string s, string t)
        {
            // solved with hints
            if (string.IsNullOrEmpty(t))
                return "";

            var ts = new Dictionary<char, int>();
            var window = new Dictionary<char, int>();

            foreach (var item in t)
            {
                if (!ts.TryGetValue(item, out int value))
                {
                    ts.Add(item, 0);
                }
                else
                {
                    ts[item] = ++value;
                }
            }

            var have = 0;
            var need = ts.Count;
            var result = new int[2];
            var resultLength = int.MaxValue;
            var left = 0;

            for (int right = 0; right < s.Length; right++)
            {
                var ch = s[right];
                if (!window.TryGetValue(ch, out var value))
                {
                    window.Add(ch, 0);
                }
                else
                {
                    window[ch] = ++value;
                }

                if (ts.TryGetValue(ch, out int val) && window[ch] == val)
                    have++;

                while (have == need)
                {
                    if((right - left + 1) < resultLength)
                    {
                        result[0] = left;
                        result[1] = right;
                        resultLength = right - left + 1;
                    }
                    window[s[left]]--;
                    if (ts.TryGetValue(s[left], out int vall) && window[s[left]] < vall)
                        have--;
                    left++;
                }
            }

            if (resultLength != int.MaxValue)
                return s[result[0]..(result[1] + 1)];
            else
                return "";
        }
    }
}
