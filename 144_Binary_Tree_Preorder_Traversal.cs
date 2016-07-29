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
    public IList<int> PreorderTraversal(TreeNode root) {
        var stack = new Stack<TreeNode>();
        var list = new List<int>();
        while (root != null) {
            list.Add(root.val);
            if (root.right != null) {
                stack.Push(root.right);
            }
            root = root.left;
            if (root == null && stack.Count != 0) {
                root = stack.Pop();
            }
        }
        return list;
    }
}