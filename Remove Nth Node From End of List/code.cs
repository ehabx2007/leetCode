/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode forwardHead = null, tempHead = head, originalHead = head;


            while (n > 0 && (tempHead.next != null)) {
                tempHead = tempHead.next;
                n--;
            }
            if (n == 0)
            {
                forwardHead = tempHead;
            }
            else {
                originalHead = originalHead.next;
                return originalHead;
            }

            while (forwardHead.next != null) {
                head = head.next;
                forwardHead = forwardHead.next;
            }
            if (head.next.next != null)
                head.next = head.next.next;
            else
                head.next = null;
            return originalHead;
    }
}