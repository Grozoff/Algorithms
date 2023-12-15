namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/first-unique-character-in-a-string/">First Unique Character in a String</see>
    /// <br>Hash Table, String, Queue, Counting</br>
    /// </summary>
    internal class Problem387
    {
        public static int FirstUniqChar(string s)
        {
            var dict = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (dict.TryGetValue(s[i], out int value))
                {
                    dict[s[i]] = ++value;
                }
                else
                {
                    dict.Add(s[i], 1);
                }
            }

            var asd = dict.FirstOrDefault(x => x.Value == 1);

            return asd.Value == 0 ? -1 : s.IndexOf(asd.Key);
        }
    }

    public class Tests387
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var input = "leetcode";
            var output = Problem387.FirstUniqChar(input);

            Assert.That(output, Is.EqualTo(0));
        }

        [Test]
        public void Test2()
        {
            var input = "loveleetcode";
            var output = Problem387.FirstUniqChar(input);

            Assert.That(output, Is.EqualTo(2));
        }

        [Test]
        public void Test3()
        {
            var input = "aabb";
            var output = Problem387.FirstUniqChar(input);

            Assert.That(output, Is.EqualTo(-1));
        }
    }
}
