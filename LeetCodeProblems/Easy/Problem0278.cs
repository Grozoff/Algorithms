namespace LeetCodeProblems.Easy
{
    /* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

    /// <summary>
    /// <see href="https://leetcode.com/problems/first-bad-version">First Bad Version</see>
    /// <br>Binary Search, Interactive</br>
    /// </summary>
    public class Problem0278 : VersionControl
    {
        public static int FirstBadVersion(int n)
        {
            // not my solution
            var low = 0;
            var high = n;
            while (low <= high)
            {
                var mid = low + (high - low) / 2;
                if (IsBadVersion(mid))
                    high = mid - 1;
                else
                    low = mid + 1;
            }

            return low;
        }
    }

    public class VersionControl
    {
        public static bool IsBadVersion(int version)
        {
            return version >= 4;
        }
    }

    public class Tests0278
    {

        [Test]
        public void Test1()
        {
            var s = 5;
            var output = Problem0278.FirstBadVersion(s);

            Assert.That(output, Is.EqualTo(4));
        }
    }
}
