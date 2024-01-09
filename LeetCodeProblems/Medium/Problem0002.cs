namespace LeetCodeProblems.Medium
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
    /// <see href="https://leetcode.com/problems/add-two-numbers/">Add Two Numbers</see>
    /// <br>Linked List, Math, Recursion</br>
    /// </summary>
    internal class Problem0002
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var val = (ToBigNumber(l1) + ToBigNumber(l2)).ToString().ToArray();
            ListNode current = null;
            ListNode previous = null;
            for (int i = 0; i < val.Length; i++)
            {
                if (i == 0)
                {
                    current = new ListNode(int.Parse($"{val[i]}"));
                }
                else
                {
                    previous = current;
                    current = new ListNode(int.Parse($"{val[i]}"), previous);
                }
            }

            return current;
        }

        public System.Numerics.BigInteger ToBigNumber(ListNode l)
        {
            var lst = string.Empty;
            ListNode node = l;
            while (node != null)
            {
                lst += node.val.ToString();
                node = node.next;
            }
            var a = lst.ToCharArray();
            Array.Reverse(a);
            return System.Numerics.BigInteger.Parse(new string(a));
        }
    }

    public class Tests2
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
        }
    }
}
