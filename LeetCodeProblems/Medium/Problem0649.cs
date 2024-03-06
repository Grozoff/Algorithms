namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/dota2-senate">Dota2 Senate</see>
    /// <br>String, Greedy, Queue</br>
    /// </summary>
    internal class Problem0649
    {
        public string PredictPartyVictory(string senate)
        {
            var senators = new Queue<char>(senate);
            var countR = senate.Count(x => x == 'R');
            var countD = senate.Length - countR;

            var scale = 0;

            while (countR > 0 && countD > 0)
            {

                var senator = senators.Dequeue();

                if (senator == 'R')
                {
                    if (scale >= 0)
                    {
                        countD--;
                        senators.Enqueue(senator);
                    }
                    scale++;
                }
                else
                {
                    if (scale <= 0)
                    {
                        countR--;
                        senators.Enqueue(senator);
                    }
                    scale--;
                }
            }

            return countR == 0 ? "Dire" : "Radiant";
        }
    }
}
