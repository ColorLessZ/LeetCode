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
    public TreeNode MergeTrees(TreeNode t1, TreeNode t2) {
        if (t1 == null & t2 == null)
        {
            return null;
        }
        
        var nodeVal = (t1 == null ? 0 : t1.val) + (t2 == null ? 0 : t2.val);
        var newNode = new TreeNode(nodeVal);
        newNode.left = MergeTrees(t1 == null ? null : t1.left, t2 == null ? null : t2.left);
        newNode.right = MergeTrees(t1 == null ? null : t1.right, t2 == null ? null : t2.right);
        return newNode;
    }
}