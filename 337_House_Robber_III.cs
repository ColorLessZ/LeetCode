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
    private Dictionary<TreeNode, int> hash = new Dictionary<TreeNode, int>();

    public int Rob(TreeNode root) {
        return RobHelper(root);
    }
    
    private int RobHelper(TreeNode root) {
        if (root == null) {
            return 0;
        }
        if (hash.ContainsKey(root)) {
            return hash[root];
        }
        
        int val = 0;
        if (root.left != null) {
            val += Rob(root.left.left) + Rob(root.left.right);
        }
        
        if (root.right != null) {
            val += Rob(root.right.left) + Rob(root.right.right);
        }
        
        var result = Math.Max(val + root.val, Rob(root.left) + Rob(root.right));
        hash.Add(root, result);
        return result;
    }
}