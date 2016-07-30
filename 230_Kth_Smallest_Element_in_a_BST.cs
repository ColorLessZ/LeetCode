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
    public int KthSmallest(TreeNode root, int k) {
        var leftNodeCount = TreeNodeCount(root.left);
        if (leftNodeCount >= k) {
            return KthSmallest(root.left, k);
        } else if (leftNodeCount + 1 < k){
            return KthSmallest(root.right, k - leftNodeCount - 1);
        }
        
        return root.val;
    }
    
    private int TreeNodeCount(TreeNode node) {
        if (node == null ) {
            return 0;
        }
        return 1 + TreeNodeCount(node.left) + TreeNodeCount(node.right);
    }
}