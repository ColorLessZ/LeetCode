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
    public int PathSum(TreeNode root, int sum) {
        if (root == null){
            return 0;
        }
        
        return PathSumHelper(root, sum) + PathSum(root.left, sum) + PathSum(root.right, sum);
    }
    
    private int PathSumHelper(TreeNode root, int sum) {
        var result = 0;
        if (root == null)
        {
            return result;
        }
        
        if (root.val == sum) {
            result += 1;
        }
        
        result += PathSumHelper(root.left, sum - root.val);
        result += PathSumHelper(root.right, sum - root.val);
        
        return result;
    }
}