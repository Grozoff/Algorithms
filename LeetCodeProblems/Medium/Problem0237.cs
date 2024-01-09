namespace LeetCodeProblems.Medium
{
    /**
    * Definition for singly-linked list.
    * public class ListNode {
    *     public int val;
    *     public ListNode next;
    *     public ListNode(int x) { val = x; }
    * }
    */

    /// <summary>
    /// <see href="https://leetcode.com/problems/delete-node-in-a-linked-list/">Delete Node in a Linked List</see>
    /// <br>Linked List</br>
    /// </summary>
    internal class Problem0237
    {
        public void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }
}
