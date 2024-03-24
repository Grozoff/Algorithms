namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/reorder-list">Reorder List</see>
    /// <br>Linked List, Two Pointers, Stack, Recursion</br>
    /// </summary>
    internal class Problem0143
    {
        public void ReorderList(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return;
            }

            var slow = head;
            var fast = head.next;

            while (fast?.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }

            var right = slow.next;
            var left = head;

            slow.next = null;

            ListNode prev = null;
            var curr = right;

            while (curr != null)
            {
                var next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }

            right = prev;

            while (right != null)
            {
                var leftTemp = left.next;
                var rightTemp = right.next;
                left.next = right;
                right.next = leftTemp;

                left = leftTemp;
                right = rightTemp;
            }
        }
    }
}
