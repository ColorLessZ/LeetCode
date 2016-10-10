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
    public int SumOfLeftLeaves(TreeNode root) {
       
        return SumOfLeftLeavesHelper(root, false);
    }
    
    private int SumOfLeftLeavesHelper(TreeNode root, bool isLeftChild) {
        if (root == null) {
            return 0;
        }
        
        if (root.left == null && root.right == null && isLeftChild) {
            return root.val;
        }
        
        return SumOfLeftLeavesHelper(root.left, true) + SumOfLeftLeavesHelper(root.right, false);
    }
}