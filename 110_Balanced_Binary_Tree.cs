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
    public bool IsBalanced(TreeNode root) {
        if (root == null) {
            return true;
        }
        
        if (Math.Abs(GetTreeHeight(root.left) - GetTreeHeight(root.right)) <= 1) {
            return IsBalanced(root.left) && IsBalanced(root.right);
        }
        
        return false;
    }
    
    private int GetTreeHeight(TreeNode node) {
        if (node == null) {
            return 0;
        }
        
        return 1 + Math.Max(GetTreeHeight(node.left), GetTreeHeight(node.right));
    }
}