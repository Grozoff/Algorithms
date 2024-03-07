namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/odd-even-linked-list">Odd Even Linked List</see>
    /// <br>Linked List</br>
    /// </summary>
    internal class Problem0328
    {
        public static ListNode OddEvenList(ListNode head)
        {
            if (head == null || head.next == null) return head;

            var odd = head;
            var even = head.next;
            var evenHead = even;
            while (even != null && even.next != null)
            {
                odd.next = even.next;
                odd = odd.next;
                even.next = odd.next;
                even = even.next;
            }
            odd.next = evenHead;
            return head;
        }
    }

    public class Test0328
    {
        [Test]
        public void Test1()
        {
            var input = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5 )))));
            var result = Problem0328.OddEvenList(input);
        }
    }
}
