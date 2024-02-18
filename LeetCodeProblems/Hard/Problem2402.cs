namespace LeetCodeProblems.Hard
{
    /// <summary>
    /// <see href='https://leetcode.com/problems/meeting-rooms-iii'>Meeting Rooms III</see>
    /// <br>Array, Hash Table, Sorting, Heap(Priority Queue), Simulation</br>
    /// </summary>
    internal class Problem2402
    {
        public int MostBooked(int n, int[][] meetings)
        {
            // not my solution

            // Counter for number of meetings held in room
            int[] rooms = new int[n];

            // List(start, end, room number)
            PriorityQueue<List<long>, long> occupiedRooms = new PriorityQueue<List<long>, long>(Comparer<long>.Create((x, y) => x.CompareTo(y)));

            // 1. Each meeting will take place in the free room with the lowest number.
            PriorityQueue<long, long> freeRooms = new PriorityQueue<long, long>();
            for (int i = 0; i < n; i++)
            {
                freeRooms.Enqueue(i, i);
            }

            // 3. Meetings that have an earlier original start time should be given the room
            Array.Sort(meetings, (x, y) => x[0].CompareTo(y[0]));
            long currentTime = 0;
            for (int i = 0; i < meetings.Length; i++)
            {
                int[] meeting = meetings[i];
                // Update time to meeting time if meeting time is later
                currentTime = Math.Max(meeting[0], currentTime);

                // If no meeting rooms left, go to time where earliest room will be cleared
                if (freeRooms.Count == 0)
                {
                    long earliestFreeTime = occupiedRooms.Peek()[1];
                    currentTime = Math.Max(earliestFreeTime, currentTime);
                }

                // Clear all rooms occuring at and before this time
                while (occupiedRooms.Count > 0 && occupiedRooms.Peek()[1] <= currentTime)
                {
                    long freedRoom = occupiedRooms.Dequeue()[2];
                    freeRooms.Enqueue(freedRoom, freedRoom);
                }

                // Occupy a new room, 
                // 2. Delayed meeting should have same duration
                long nextRoom = freeRooms.Dequeue();
                rooms[nextRoom] += 1;
                occupiedRooms.Enqueue(new List<long> { currentTime, currentTime + (meeting[1] - meeting[0]), nextRoom }, currentTime + (meeting[1] - meeting[0]));
            }

            // Get smallest room with largest meetings held
            int max = 0, ansRoom = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                if (rooms[i] >= max)
                {
                    max = rooms[i];
                    ansRoom = i;
                }
            }
            return ansRoom;
        }
    }
}
