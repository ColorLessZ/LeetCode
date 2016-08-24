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
    public int SumNumbers(TreeNode root) {
        return SumNumbersHelper(root, 0);
    }
    
    private int SumNumbersHelper(TreeNode node, int preSum) {
        if (node == null) {
            return 0;
        }
        
        if (node.left == null && node.right == null) {
            return preSum*10 + node.val;
        }
        
        return SumNumbersHelper(node.left, preSum*10 + node.val) + SumNumbersHelper(node.right, preSum*10+node.val);
    }
}