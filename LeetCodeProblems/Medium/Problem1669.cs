namespace LeetCodeProblems.Medium
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/merge-in-between-linked-lists">Merge In Between Linked Lists</see>
    /// <br>Linked List</br>
    /// </summary>
    internal class Problem1669
    {
        public static ListNode MergeInBetween(ListNode list1, int a, int b, ListNode list2)
        {
            var dummyHead = new ListNode(0);
            var current = dummyHead;
            b-=a;
            while (a != 0 && list1 != null)
            {
                current.next = list1;
                current = current.next;
                list1 = list1.next;
                a--;
            }
            while (list2 != null)
            {
                current.next = list2;
                current = current.next;
                list2 = list2.next;
            }


            while (b != 0 && list1 != null)
            {
                list1 = list1.next;
                b--;
            }
            current.next = list1.next;

            return dummyHead.next;
        }
    }

    public class Tests1669
    {
        [Test]
        public void Test1()
        {
            ListNode list1 = new ListNode(10, new ListNode(1, new ListNode(13, new ListNode(6, new ListNode(9, new ListNode(5))))));
            ListNode list2 = new ListNode(1000000, new ListNode(1000001, new ListNode(1000002)));
            var output = Problem1669.MergeInBetween(list1, 3, 4, list2);
        }
    }
}
