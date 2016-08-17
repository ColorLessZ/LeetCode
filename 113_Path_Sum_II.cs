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
    public IList<IList<int>> PathSum(TreeNode root, int sum) {
        var results = new List<IList<int>>();
        var list = new List<int>();
        PathSumHelper(root, sum, results, list);
        return results;
        
    }
    
    private void PathSumHelper(TreeNode root, int sum, List<IList<int>> results, List<int> list){
        if (root == null) {
            return;
        }
        if (root.left == null && root.right == null) {
            if (sum == root.val){
                var newList = new List<int>(list);
                newList.Add(root.val);
                results.Add(newList);
            }
        }
        
        list.Add(root.val);
        PathSumHelper(root.left, sum-root.val, results, list);
        PathSumHelper(root.right, sum-root.val, results, list);
        list.RemoveAt(list.Count -1);
    }
}