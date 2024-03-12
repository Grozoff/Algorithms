namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/remove-zero-sum-consecutive-nodes-from-linked-list">Remove Zero Sum Consecutive Nodes from Linked List</see>
    /// <br>Hash Table, Linked List</br>
    /// </summary>
    internal class Problem1171
    {
        public static ListNode RemoveZeroSumSublists(ListNode head)
        {
            var dict = new Dictionary<int, ListNode>();
            var dummy = new ListNode(0, head);
            var sum = 0;
            var point = dummy;
            while (point != null)
            {
                sum += point.val;
                if (dict.TryGetValue(sum, out var node))
                {
                    point = node.next;
                    var s = sum + point.val;
                    while (s != sum)
                    {
                        dict.Remove(s);
                        point = point.next;
                        s += point.val;
                    }

                    node.next = point.next;
                }
                else
                {
                    dict.Add(sum, point);
                }
                point = point.next;
            }

            return dummy.next;
        }
    }

    public class Test1171
    {
        [Test]
        public void Test1()
        {
            var input = new ListNode(1, new ListNode(2, new ListNode(-3, new ListNode(3, new ListNode(1)))));
            var result = Problem1171.RemoveZeroSumSublists(input);
        }
    }
}
