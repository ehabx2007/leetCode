/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode OddEvenList(ListNode head) {
       
        bool IsOdd = true;
        ListNode NodeOdd = null;
        ListNode NodeEven = null,NodeEvenHead = null;
        ListNode NodeHead = null;
        if (head == null)
                return null;
        while (head != null) {
            if (IsOdd)
            {
                if (NodeOdd == null)
                {
                    NodeOdd = head;
                    NodeHead = NodeOdd;
                }
                else
                {
                    NodeOdd.next = head;
                    NodeOdd = NodeOdd.next;
                }
            }
            else {
                if (NodeEven == null)
                {
                    NodeEven = head;
                    NodeEvenHead = NodeEven;
                }
                else {
                    NodeEven.next = head;
                    NodeEven = NodeEven.next;
                }
            }

            head = head.next;
            IsOdd = !IsOdd;
        }
        if (NodeEven != null)
                NodeEven.next = null;
        NodeOdd.next = NodeEvenHead;
        return NodeHead;
       
    }
}