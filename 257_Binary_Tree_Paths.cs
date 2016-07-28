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
    public IList<String> BinaryTreePaths(TreeNode root) {
        var answer = new List<String>();
        if (root != null) SearchBT(root, "", answer);
        return answer;
    }
    private void SearchBT(TreeNode root, String path, List<String> answer) {
        if (root.left == null && root.right == null) answer.Add(path + root.val);
        if (root.left != null) SearchBT(root.left, path + root.val + "->", answer);
        if (root.right != null) SearchBT(root.right, path + root.val + "->", answer);
    }
}