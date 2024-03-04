namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/asteroid-collision">Asteroid Collision</see>
    /// <br>Array, Stack, Simulation</br>
    /// </summary>
    internal class Problem0735
    {
        public int[] AsteroidCollision(int[] asteroids)
        {
            var hs = new Stack<int>();
            foreach (var a in asteroids)
            {
                if (hs.Count == 0 || a > 0)
                {
                    hs.Push(a);
                }
                else
                {
                    if (hs.Peek() > 0 && a < 0)
                    {
                        while (true)
                        {
                            if (hs.Count == 0 || hs.Peek() < 0)
                            {
                                hs.Push(a);
                                break;
                            }
                            if (hs.Peek() + a == 0)
                            {
                                hs.Pop();
                                break;
                            }
                            else if (hs.Peek() + a > 0)
                            {
                                break;
                            }
                            else
                            {
                                hs.Pop();
                            }
                        }
                    }
                    else
                    {
                        hs.Push(a);
                    }
                }
            }

            return hs.Reverse().ToArray();
        }
    }
}
