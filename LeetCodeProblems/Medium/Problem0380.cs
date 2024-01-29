namespace LeetCodeProblems.Medium
{
    internal class Problem0380
    {
    }

    /// <summary>
    /// <see href='https://leetcode.com/problems/insert-delete-getrandom-o1/'>Insert Delete GetRandom O(1)</see>
    /// <br>Array, Hash Table, Math, Design, Randomized</br>
    /// </summary>
    public class RandomizedSet
    {
        private HashSet<int> _set;
        private Random _random;

        public RandomizedSet()
        {
            _set = new HashSet<int>();
            _random = new Random();
        }

        public bool Insert(int val)
        {
            return _set.Add(val);
        }

        public bool Remove(int val)
        {
            return _set.Remove(val);
        }

        public int GetRandom()
        {
            var asArray = _set.ToArray();
            return asArray[_random.Next(asArray.Length)];
        }
    }

    /// <summary>
    /// not my solution
    /// </summary>
    public class RandomizedSet2
    {
        private List<int> values;
        private Dictionary<int, int> indexMap;
        private Random _random = new Random();
        public RandomizedSet2()
        {
            values = new List<int>();
            indexMap = new Dictionary<int, int>();
        }

        public bool Insert(int val)
        {
            if (indexMap.ContainsKey(val))
                return false;

            values.Add(val);
            indexMap.Add(val, values.Count - 1);

            return true;
        }

        public bool Remove(int val)
        {
            if (!indexMap.ContainsKey(val))
            {
                return false;
            }
            int index = indexMap[val];
            (values[index], values[^1]) = (values[^1], values[index]);
            indexMap[values[index]] = index;

            values.RemoveAt(values.Count - 1);
            indexMap.Remove(val);
            return true;
        }

        public int GetRandom()
        {
            var val = _random.Next(0, values.Count);
            return values[val];
        }
    }
}
