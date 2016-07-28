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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if (ContainNode(root, p) && ContainNode(root, q)) {
            if ((ContainNode(root.left, p) && !ContainNode(root.left, q)) || (ContainNode(root.left, q) && !ContainNode(root.left, p))) {
                return root;
            }
            
            if ((ContainNode(root.right, p) && !ContainNode(root.right, q)) || (ContainNode(root.right, q) && !ContainNode(root.right, p)))  {
                return root;
            } 
            
            if (ContainNode(root.left, p)) {
                return LowestCommonAncestor(root.left, p, q);
            }
            
            if (ContainNode(root.right, p)) {
                return LowestCommonAncestor(root.right, p, q);
            }
            
        }
        
        return null;
        
    }
    
    public bool ContainNode(TreeNode root, TreeNode p) {
        if (root == null){
            return false;
        }
        
        if (root == p || root.left == p || root.right == p){
            return true;
        }
        
        return ContainNode(root.left, p) || ContainNode(root.right, p);
    }
}