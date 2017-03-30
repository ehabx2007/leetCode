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
    public ArrayList<ArrayList<Integer>> pathSum(TreeNode root, int sum) {
        ArrayList<ArrayList<Integer>> paths = new ArrayList<ArrayList<Integer>>();

            if (root != null)
                traceSum(root, 0, sum, paths, new ArrayList<Integer>());
            
            return paths;
    }
    
    public void traceSum(TreeNode node, int sum, int goalSum, ArrayList<ArrayList<Integer>> paths, ArrayList<Integer> currentPath)
        {
            sum += node.val;
            if ((node.left == null) && (node.right == null))
            {
                if (sum == goalSum)
                {
                    currentPath.add(node.val);
                    paths.add(currentPath);
                    return;
                }
                else
                {
                    return;
                }
            }
            else 
            {
                
                
                if (node.left != null)
                {
                    ArrayList<Integer> newPath = new ArrayList<Integer>();
                newPath.addAll(currentPath);
                newPath.add(node.val);
                
                    traceSum(node.left, sum, goalSum,paths, newPath);
                }
                if (node.right != null)
                {
                    ArrayList<Integer> newPath = new ArrayList<Integer>();
                newPath.addAll(currentPath);
                newPath.add(node.val);
                
                    traceSum(node.right, sum, goalSum, paths, newPath);
                }
            }
        }
}