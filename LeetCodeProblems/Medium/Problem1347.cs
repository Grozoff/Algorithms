namespace LeetCodeProblems.Medium
{
    internal class Problem1347
    {
        public static int MinSteps(string s, string t)
        {
            // my solution
            var count = 0;
            var hs = new HashSet<char>();
            for (var i = 0; i < s.Length; i++)
            {
                if (hs.Add(s[i]))
                {
                    var tCount = t.Count(c => c == s[i]);
                    var sCount = s.Count(c => c == s[i]);
                    if (tCount < sCount)
                        count += sCount - tCount;
                }
            }

            return count;

            // not my solution

            int[] charCount = new int[26]; // Assuming lowercase English letters only

            // Count characters in string s
            foreach (char c in s)
            {
                charCount[c - 'a']++;
            }

            // Count characters in string t and calculate the difference
            int steps = 0;
            foreach (char c in t)
            {
                if (charCount[c - 'a'] == 0)
                {
                    steps++; // Character in t that is not in s
                }
                else
                {
                    charCount[c - 'a']--;
                }
            }

            return steps;
        }
    }

    public class Tests1347
    {
        [Test]
        public void Test1()
        {
            var s = "bab";
            var t = "aba";
            var output = Problem1347.MinSteps(s, t);

            Assert.That(output, Is.EqualTo(1));
        }
    }
}
