namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/maximum-twin-sum-of-a-linked-list">Maximum Twin Sum of a Linked List</see>
    /// <br>Linked List, Two Pointers, Stack</br>
    /// </summary>
    internal class Problem2130
    {
        public static int PairSum(ListNode head)
        {
            var max = 0;
            var st = new Stack<int>();
            st.Push(head.val);
            var slow = head;
            var fast = head.next;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                st.Push(slow.val);
                fast = fast.next.next;
            }

            while (slow.next != null)
            {
                slow = slow.next;
                max = Math.Max(max, st.Pop() + slow.val);
            }

            return max;
        }
    }

    public class Test2130
    {
        [Test]
        public void Test1()
        {
            var input = new ListNode(5, new ListNode(4, new ListNode(2, new ListNode(1))));
            var result = Problem2130.PairSum(input);
        }
    }
}
