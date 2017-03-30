/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public ListNode mergeTwoLists(ListNode l1, ListNode l2) {
        if (l1 == null)
            return l2;
        if (l2 == null)
            return l1;

        ListNode newHead = null, originalHead = null;


        if (l1.val > l2.val)
        {
            newHead = l2;
            l2 = l2.next;
        }
        else
        {
            newHead = l1;
            l1 = l1.next;
        }

        originalHead = newHead;

        while ((l1 != null) && (l2 != null))
        {
            if (l1.val > l2.val)
            {
                newHead.next = l2;
                l2 = l2.next;
            }
            else
            {
                newHead.next = l1;
                l1 = l1.next;
            }

            newHead = newHead.next;
        }

        if (l1 == null)
        {
            newHead.next = l2;
        }
        else
        {
            newHead.next = l1;
        }

        return originalHead;
    }
}