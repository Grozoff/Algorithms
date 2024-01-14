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
