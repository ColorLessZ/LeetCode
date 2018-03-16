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
    int max;
    
    public int LongestUnivaluePath(TreeNode root) {
        max = 0;
        helper(root);
        return max;
    }
    
    private int helper(TreeNode node){
        if (node == null) {
            return 0;
        }
        
        var value = node.val;
        var left = helper(node.left);
        var right = helper(node.right);
        
        var leftMax = 0;
        var rightMax = 0;
        if (node.left != null && node.left.val == value){
            leftMax += left + 1;
        }
        
        if (node.right != null && node.right.val == value){
            rightMax += right + 1;
        }
        
        max = Math.Max(max, rightMax + leftMax);
        return Math.Max(rightMax, leftMax);
    }
}