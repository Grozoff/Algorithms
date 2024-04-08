namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/number-of-students-unable-to-eat-lunch">Number of Students Unable to Eat Lunch</see>
    /// <br>Array, Stack, Queue, Simulation</br>
    /// </summary>
    internal class Problem1700
    {
        public int CountStudents(int[] students, int[] sandwiches)
        {
            var ones = 0;
            var zeros = 0;
            foreach (var s in students)
            {
                if (s == 1)
                    ones++;
                else
                    zeros++;
            }
            foreach (var s in sandwiches)
            {
                if (ones == 0 && s == 1)
                    break;
                if (zeros == 0 && s == 0)
                    break;
                if (ones > 0 && s == 1)
                    ones--;
                if (zeros > 0 && s == 0)
                    zeros--;
            }

            return ones + zeros;

            // not my solution
            int[] count = new int[2]; // count[0] for circular sandwiches, count[1] for square sandwiches

            foreach (int student in students)
            {
                count[student]++;
            }

            int i = 0;
            while (i < sandwiches.Length)
            {
                if (count[sandwiches[i]] == 0)
                {
                    break; // No more students who prefer this type of sandwich
                }

                count[sandwiches[i]]--; // Mark one sandwich as eaten by a student

                i++;
            }

            return students.Length - i;
        }
    }
}
