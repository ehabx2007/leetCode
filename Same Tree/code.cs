/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public bool IsSameTree(TreeNode p, TreeNode q) {
        string pTraverse = Traverse(p);
            string qTraverse = Traverse(q);

            return pTraverse.Equals(qTraverse);
    }
    
    private string Traverse(TreeNode node)
        {
            if (node == null)
                return string.Empty;

            return string.Format("{0} {1} {2} ", Traverse(node.left), node.val, Traverse(node.right));
        }
}