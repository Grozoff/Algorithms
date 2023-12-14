namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/ransom-note/">Ransom Note</see>
    /// <br>Hash Table, String, Counting</br>
    /// </summary>
    internal class Problem383
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            // Assuming only lowercase English letters
            int[] charFrequency = new int[26];

            // Count the frequency of each character in the magazine
            foreach (char c in magazine)
            {
                charFrequency[c - 'a']++;
            }

            // Check if ransomNote can be constructed
            foreach (char c in ransomNote)
            {
                int index = c - 'a';
                if (charFrequency[index] <= 0)
                {
                    return false;
                }
                else
                {
                    charFrequency[index]--;
                }
            }

            return true;
        }
    }
}
