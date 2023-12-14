namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/valid-anagram/">Valid Anagram</see>
    /// <br>Hash Table,String, Sorting</br>
    /// </summary>
    internal class Problem242
    {
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
            if (s == t)
                return true;

            return s.OrderBy(x => x).SequenceEqual(t.OrderBy(x => x));
        }
    }

    public class Tests242
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var s = "aacc";
            var t = "ccac";
            var output = Problem242.IsAnagram(s, t);

            Assert.That(output, Is.EqualTo(false));
        }

        [Test]
        public void Test2()
        {
            var s = "anagram";
            var t = "nagaram";
            var output = Problem242.IsAnagram(s, t);

            Assert.That(output, Is.EqualTo(true));
        }
    }
}
