namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/reverse-linked-list/">Reverse Linked List</see>
    /// <br>Linked List, Recursion</br>
    /// </summary>
    internal class Problem0206
    {
        public ListNode ReverseList(ListNode head)
        {
            // my solution
            var dummy = new ListNode(0, head);
            var current = head;
            var lst = new List<int>();

            while (dummy?.next != null)
            {
                lst.Add(dummy.next.val);
                dummy = dummy.next;
            }

            for (int i = lst.Count - 1; i >= 0; i--)
            {
                current.val = lst[i];
                current = current.next;
            }

            return head;

            // not my solution
            ListNode newHead = null;
            while (head != null)
            {
                var next = head.next;

                head.next = newHead;
                newHead = head;

                head = next;
            }
            return newHead;
        }
    }
}
