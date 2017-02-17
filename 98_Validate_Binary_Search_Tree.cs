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
    public bool IsValidBST(TreeNode root) {
        return IsValidBSTHelper(root, long.MinValue, long.MaxValue);
    }
    
    public bool IsValidBSTHelper(TreeNode root, long minVal, long maxVal) {
        if (root == null) {
            return true;
        }
        
        if (root.val >= maxVal || root.val <= minVal) {
            return false;
        }
        
        return IsValidBSTHelper(root.left, minVal, root.val) && IsValidBSTHelper(root.right, root.val, maxVal);
    }
}