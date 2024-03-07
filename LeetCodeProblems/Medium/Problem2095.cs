namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/delete-the-middle-node-of-a-linked-list">Delete the Middle Node of a Linked List</see>
    /// <br>Linked List, Two Pointers</br>
    /// </summary>
    internal class Problem2095
    {
        public static ListNode DeleteMiddle(ListNode head)
        {
            if (head.next == null) return null;

            var slow = head;
            var fast = head.next;
            while (fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            slow.next = slow.next.next;
            return head;
        }
    }

    public class Test2095
    {
        [Test]
        public void Test1()
        {
            var input = new ListNode(1, new ListNode(3, new ListNode(4, new ListNode(7, new ListNode(1, new ListNode(2, new ListNode(6)))))));
            var result = Problem2095.DeleteMiddle(input);
        }
    }
}
