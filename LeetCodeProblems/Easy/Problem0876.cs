namespace LeetCodeProblems.Easy
{

    //Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    /// <summary>
    /// <see href="https://leetcode.com/problems/middle-of-the-linked-list/">Middle of the Linked List</see>
    /// <br>Linked List, Two Pointers</br>
    /// </summary>
    internal class Problem0876
    {
        public ListNode MiddleNode(ListNode head)
        {
            if (head.next == null)
            {
                return head;
            }

            ListNode current = head;
            var count = 0;
            while (true)
            {
                if (current.next == null)
                {
                    count++;
                    break;
                }
                current = current.next;
                count++;
            }

            var middle = count / 2;

            count = 0;
            current = head;
            while (true)
            {
                if (count == middle)
                {
                    return current;
                }
                current = current.next;
                count++;
            }
        }
    }
}
