namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/isomorphic-strings">Isomorphic Strings</see>
    /// <br>Hash Table, String</br>
    /// </summary>
    internal class Problem0205
    {
        public bool IsIsomorphic(string s, string t)
        {
            // There are total 256 ascii characters
            int[] arr1 = new int[256];
            int[] arr2 = new int[256];
            for (int i = 0; i < s.Length; i++)
            {
                if (arr1[s[i]] != arr2[t[i]])
                {
                    return false;
                }
                arr1[s[i]] = i + 1;
                arr2[t[i]] = i + 1;
            }
            return true;

            var dict = new Dictionary<char, char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dict.TryGetValue(s[i], out var val))
                {
                    if (t[i] != val)
                    {
                        return false;
                    }
                    continue;
                }
                if (dict.ContainsValue(t[i]))
                {
                    return false;
                }
                dict.Add(s[i], t[i]);
            }

            return true;
        }
    }
}
