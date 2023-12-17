using LeetCodeProblems.Medium;
using Newtonsoft.Json.Linq;

namespace LeetCodeProblems.Easy
{
    /// <summary>
    /// <see href="https://leetcode.com/problems/merge-two-sorted-lists/">Merge Two Sorted Lists</see>
    /// <br>Linked List, Recursion</br>
    /// </summary>
    internal class Problem21
    {
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            // not my solution
            var dummyHead = new ListNode(-1);
            // Create a dummy node as the starting point
            var current = dummyHead;
            // Pointer to keep track of the current node

            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    list2 = list2.next;
                }
                current = current.next;
            }

            // Attach the remaining nodes if any
            if (list1 != null)
            {
                current.next = list1;
            }
            else
            {
                current.next = list2;
            }

            return dummyHead.next;

            /// my solution
            //var result = new ListNode(-1);

            //var currentOne = list1;
            //var currentTwo = list2;

            //var row = new List<int>();

            //while (currentOne != null || currentTwo != null)
            //{
            //    if (currentOne != null)
            //    {
            //        row.Add(currentOne.val);
            //        currentOne = currentOne.next;
            //    }
            //    if (currentTwo != null)
            //    {
            //        row.Add(currentTwo.val);
            //        currentTwo = currentTwo.next;
            //    }
            //}

            //row.Sort();

            //foreach (var item in row)
            //{
            //    var toAdd = new ListNode(item, null);

            //    var current = result;
            //    while (current.next != null)
            //    {
            //        current = current.next;
            //    }

            //    current.next = toAdd;
            //}

            //return result.next;
        }
    }

    public class Tests221
    {
        [Test]
        public void Test1()
        {
            // list1 = []
            ListNode list1 = null;
            // list2 = [0]
            ListNode list2 = new ListNode(0);
            var output = Problem21.MergeTwoLists(list1, list2);

            //Assert.That(output, Is.EqualTo(false));
        }

        [Test]
        public void Test2()
        {
            // list1 = []
            ListNode list1 = null;
            // list2 = [0]
            ListNode list2 = new ListNode(0);
            var output = Problem21.MergeTwoLists(list2, list1);

            //Assert.That(output, Is.EqualTo(false));
        }
    }
}
