/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        if (head == null)
                return null;
            ListNode OriginalHead = head;
            ListNode PreviousNode = head;
            head = head.next;
            while (head != null) {
                if (head.val == PreviousNode.val)
                {
                    PreviousNode.next = head.next;
                }
                else {
                    PreviousNode = head;
                }
                
                head = head.next;
            }

            return OriginalHead;
    }
}