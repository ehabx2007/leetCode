/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public void DeleteNode(ListNode node) {
       ListNode previous = null;
            while (node.next != null)
            {
                node.val = node.next.val;
                previous = node;
                node = node.next;
            }
            if (previous != null) {
                previous.next = null;
            }
    }
}