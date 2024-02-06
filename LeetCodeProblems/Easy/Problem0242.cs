namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/valid-anagram/">Valid Anagram</see>
    /// <br>Hash Table,String, Sorting</br>
    /// </summary>
    internal class Problem0242
    {
        public static bool IsAnagram(string s, string t)
        {
            var c1 = s.ToArray();
            var c2 = t.ToArray();

            Array.Sort(c1);
            Array.Sort(c2);

            return c1.SequenceEqual(c2);
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
            var output = Problem0242.IsAnagram(s, t);

            Assert.That(output, Is.EqualTo(false));
        }

        [Test]
        public void Test2()
        {
            var s = "anagram";
            var t = "nagaram";
            var output = Problem0242.IsAnagram(s, t);

            Assert.That(output, Is.EqualTo(true));
        }
    }
}
