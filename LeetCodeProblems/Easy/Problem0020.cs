namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/valid-parentheses/">Valid Parentheses</see>
    /// <br>String, Stack</br>
    /// </summary>
    internal class Problem0020
    {
        public static bool IsValid(string s)
        {
            if (s.Length == 1 || s.Length % 2 != 0)
            {
                return false;
            }
            
            // it's not my solution (failed)
            var k = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(') { k.Push(')'); continue; }
                if (c == '{') { k.Push('}'); continue; }
                if (c == '[') { k.Push(']'); continue; }
                if (k.Count == 0 || c != k.Pop()) return false;
            }

            return k.Count == 0;
        }
    }

    public class Tests20
    {
        [Test]
        public void Test1()
        {
            var s = "()";
            var output = Problem0020.IsValid(s);

            Assert.That(output, Is.EqualTo(true));
        }

        [Test]
        public void Test2()
        {
            var s = "()[]{}";
            var output = Problem0020.IsValid(s);

            Assert.That(output, Is.EqualTo(true));
        }

        [Test]
        public void Test3()
        {
            var s = "(]";
            var output = Problem0020.IsValid(s);

            Assert.That(output, Is.EqualTo(false));
        }

        [Test]
        public void Test4()
        {
            var s = "([]{})";
            var output = Problem0020.IsValid(s);

            Assert.That(output, Is.EqualTo(true));
        }

        [Test]
        public void Test5()
        {
            var s = "([)]";
            var output = Problem0020.IsValid(s);

            Assert.That(output, Is.EqualTo(false));
        }

        [Test]
        public void Test6()
        {
            var s = "(){}}{";
            var output = Problem0020.IsValid(s);

            Assert.That(output, Is.EqualTo(false));
        }

        [Test]
        public void Test7()
        {
            var s = "({[)";
            var output = Problem0020.IsValid(s);

            Assert.That(output, Is.EqualTo(false));
        }

        [Test]
        public void Test8()
        {
            var s = ")(){}";
            var output = Problem0020.IsValid(s);

            Assert.That(output, Is.EqualTo(false));
        }

        [Test]
        public void Test9()
        {
            var s = "(([]){})";
            var output = Problem0020.IsValid(s);

            Assert.That(output, Is.EqualTo(true));
        }

        [Test]
        public void Test10()
        {
            var s = "[({(())}[()])]";
            var output = Problem0020.IsValid(s);

            Assert.That(output, Is.EqualTo(true));
        }
    }
}
