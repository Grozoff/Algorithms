namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/remove-nth-node-from-end-of-list/">Remove Nth Node From End of List</see>
    /// <br>Linked List, Two Pointers</br>
    /// </summary>
    internal class Problem0019
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode dummy = new(0, head);
            var slow = dummy;
            var fast = dummy;
            var counter = -1;

            while (fast != null)
            {
                if (counter < n)
                {
                    fast = fast?.next;
                    counter++;
                }
                else
                {
                    slow = slow.next;
                    fast = fast?.next;
                }
            }

            slow.next = slow.next.next;

            return dummy.next;
        }
    }
}
