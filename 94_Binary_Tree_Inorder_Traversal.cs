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
    public IList<int> InorderTraversal(TreeNode root) {
        var stack = new Stack<TreeNode>();
        var list = new List<int>();
        var cur = root;
        while (cur != null || stack.Count != 0){
            while (cur != null) {
                stack.Push(cur);
                cur = cur.left;
            }
            cur = stack.Pop();
            list.Add(cur.val);
            cur = cur.right;
        }
        
        return list;
    }
}