namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/palindrome-linked-list/">Palindrome Linked List</see>
    /// <br>Linked List, Two Pointers, Stack, Recursion</br>
    /// </summary>
    internal class Problem0234
    {
        public bool IsPalindrome(ListNode head)
        {
            var current = head;
            var lst = new Stack<int>();

            while (head?.next != null)
            {
                lst.Push(head.next.val);
                head = head.next;
            }

            while (lst.Count > 0)
            {
                if (lst.Pop() != current.val)
                {
                    return false;
                }

                current = current.next;
            }

            return true;
        }
    }
}
