/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode SwapPairs(ListNode head) {
        ListNode OldHead = null;
            bool IsOdd = true;

            ListNode temp1 = null, temp2 = null, parent = null;
            if (head == null)
                return null;
            if (head.next == null)
                return head;
            

            while (head != null) {
                if (IsOdd && head.next != null)
                {
                    temp1 = head;
                    temp2 = head.next.next;
                    head = head.next;
                    head.next = temp1;
                    if (temp2 != null)
                        head.next.next = temp2;
                    else
                        head.next.next = null;

                    if (OldHead == null)
                    {
                        OldHead = head;
                    }
                    if (parent != null)
                        parent.next = head;
                }
                else {
                    parent = temp1;
                    if (temp1 != null)
                    {
                        head = temp1.next;
                        temp1 = null;
                    }
                    else {
                        break;
                    }
                    
                    
                }
                    
                IsOdd = !IsOdd;
            }

            return OldHead;
    }
}