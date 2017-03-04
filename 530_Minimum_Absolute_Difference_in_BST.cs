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
    public int GetMinimumDifference(TreeNode root) {
        var nodeList = new List<int>();
        InOrderTraverse(root, nodeList);
        return GetMin(nodeList);
    }
    
    public void InOrderTraverse(TreeNode root, List<int> list) {
        if (root == null) {
            return;
        }
        InOrderTraverse(root.left, list);
        list.Add(root.val);
        InOrderTraverse(root.right, list);
    }
    
    public int GetMin(List<int> list) {
        var min = Int32.MaxValue;
        for(int i = 1; i < list.Count; i++) {
            min = Math.Min(Math.Abs(list[i] - list [i-1]), min);
        }
        
        if (list.Count == 1) {
            min = list[0];
        }
        
        return min;
    }
}