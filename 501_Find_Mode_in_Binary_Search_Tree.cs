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
    private List<int> modes = new List<int>();
    private int currentVal = int.MinValue;
    private int maxCount = 0;
    private int currentCount = 0;
    
    public int[] FindMode(TreeNode root) {
        InOrder(root);
        return modes.ToArray();
    }
    
    private void FindMode(int value) {
        if (currentVal != value) {
            currentVal = value;
            currentCount = 0;
        }
        
        currentCount += 1;
        if (maxCount < currentCount) {
            maxCount = currentCount;
            modes.Clear();
            modes.Add(value);
        } else if (maxCount == currentCount) {
            modes.Add(value);
        }
    }
    
    private void InOrder(TreeNode root) {
        if (root == null){
            return;
        } 
        
        InOrder(root.left);
        FindMode(root.val);
        InOrder(root.right);
    } 
}