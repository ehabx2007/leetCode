/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode(int x) { val = x; next = null; }
 * }
 */
/**
 * Definition for binary tree
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    private TreeNode _head = null;
    public TreeNode sortedListToBST(ListNode head) {
        List<Integer> list = new ArrayList<Integer>();
        
        while (head != null)
        {
            list.add(head.val);
            head = head.next;
        }
        
        AddSortedArray(list, 0, list.size() - 1);
        
        return _head;
    }
    
    public void AddSortedArray(List<Integer> array, int from, int to)
    {
        if (from == to)
        {
            Add(array.get(from).intValue());
            return;
        }
        else if (from > to)
        {
            return;
        }
        int index = ((to - from) / 2) + from;
        Add(array.get(index).intValue());

        AddSortedArray(array, from, index - 1);
        AddSortedArray(array, index + 1, to);
    }

    public void Add(int data)
    {
        
        if (_head == null)
        {
            _head = new TreeNode(data);
           
        }
        else
        {
             AddNode(_head, data);
        }
    }

    public void AddNode(TreeNode head, int data)
    {
        if (head.val >= data)
        {
            if (head.left == null)
            {
                head.left = new TreeNode(data);
            }
            else
            {
                AddNode(head.left, data);
            }
        }
        else
        {
            if (head.right == null)
            {
                head.right = new TreeNode(data);
            }
            else
            {
                AddNode(head.right, data);
            }
        }
    }
}