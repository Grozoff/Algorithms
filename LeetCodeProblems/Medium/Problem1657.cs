namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/determine-if-two-strings-are-close/'>Determine if Two Strings Are Close</see>
    /// <br>Hash Table, String, Sorting, Counting</br>
    /// </summary>
    internal class Problem1657
    {
        public static bool CloseStrings(string word1, string word2)
        {
            if (word1.Length != word2.Length)
                return false;

            if (!word1.ToHashSet().SetEquals(word2.ToHashSet()))
                return false;

            var charCount1 = new int[26];
            var charCount2 = new int[26];

            foreach (char c in word1)
            {
                charCount1[c - 'a']++;
            }

            foreach (char c in word2)
            {
                charCount2[c - 'a']++;
            }

            Array.Sort(charCount1);
            Array.Sort(charCount2);

            return charCount1.SequenceEqual(charCount2);

            // not my solution
            if (word1.Length != word2.Length) return false;

            int[] frequency1 = new int[26];
            int[] frequency2 = new int[26];

            for (int index = 0; index < word1.Length; index++)
            {
                frequency1[word1[index] - 'a']++;
                frequency2[word2[index] - 'a']++;
            }

            for (int index = 0; index < 26; index++)
            {
                if (frequency1[index] == 0 && frequency2[index] != 0)
                    return false;
                if (frequency1[index] != 0 && frequency2[index] == 0)
                    return false;
            }

            Array.Sort(frequency1);
            Array.Sort(frequency2);

            return frequency1.SequenceEqual(frequency2);
        }
    }

    public class Tests1657
    {
        [Test]
        public void Test1()
        {
            var s = "cabbba";
            var t = "abbccc";
            var output = Problem1657.CloseStrings(s, t);

            Assert.True(output);
        }

        [Test]
        public void Test2()
        {
            var s = "cabbba";
            var t = "aabbss";
            var output = Problem1657.CloseStrings(s, t);

            Assert.False(output);
        }

        [Test]
        public void Test3()
        {
            var s = "uau";
            var t = "ssx";
            var output = Problem1657.CloseStrings(s, t);

            Assert.False(output);
        }
    }
}
