namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/keys-and-rooms'>Keys and Rooms</see>
    /// <br>Depth-First Search, Breadth-First Search, Graph</br>
    /// </summary>
    internal class Problem0841
    {
        public bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            var visited = new bool[rooms.Count];
            visited[0] = true;
            var st = new Stack<int>();
            st.Push(0);

            while (st.Count != 0)
            {
                var room = st.Pop();
                foreach (var key in rooms[room])
                {
                    if (!visited[key])
                    {
                        visited[key] = true;
                        st.Push(key);
                    }
                }
            }

            return !visited.Contains(false);
        }
    }
}
