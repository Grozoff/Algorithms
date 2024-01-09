namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/linked-list-cycle/">Linked List Cycle</see>
    /// <br>Hash Table, Linked List, Two Pointers</br>
    /// </summary>
    internal class Problem0141
    {
        public bool HasCycle(ListNode head)
        {
            var fast = head;
            var slow = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
