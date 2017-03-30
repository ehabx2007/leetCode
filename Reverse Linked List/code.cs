/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        if (head == null)
                return head;
            Stack<int> stack = new Stack<int>();
            while (head.next != null) {
                stack.Push(head.val);
                head = head.next;
            }
            ListNode newHead = head;
            while (stack.Count > 0) {
                head.next = new ListNode(stack.Pop());
                head = head.next;
            }
            
            return newHead;
    }
}