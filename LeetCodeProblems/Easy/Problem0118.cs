namespace LeetCodeProblems.Easy
{
    internal class Problem0118
    {
        public static IList<IList<int>> Generate(int numRows)
        {
            var result = new List<IList<int>>
            {
                new List<int>() { 1 }
            };

            if (numRows == 1)
            {
                return result;
            }

            result.Add(new List<int>() { 1, 1 });
            var index = 0;
            while (numRows != result.Count)
            {
                var line = new List<int>() { 1 };
                while (true)
                {
                    if ((index + 1) == result.Count)
                    {
                        break;
                    }

                    line.Add(result[^1][index] + result[^1][index + 1]);
                    index++;
                }
                line.Add(1);
                result.Add(line);
                index = 0;
            }

            return result;
        }
    }

    public class Tests0118
    {
        [Test]
        public void Test1()
        {
            var input = 5;
            var output = Problem0118.Generate(input);
        }
    }
}
