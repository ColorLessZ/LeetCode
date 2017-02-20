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
    public IList<int> LargestValues(TreeNode root) {
        var result = new List<int>();
        var queue = new Queue<TreeNode>();
        var max = int.MinValue;
        if (root!=null) {
            queue.Enqueue(root);
        }
        
        while (queue.Count != 0) {
            var queueLength = queue.Count;
            for(int i = 0; i < queueLength; i++) {
                var node = queue.Dequeue();
                max = Math.Max(max, node.val);
                if(node.left!=null){
                    queue.Enqueue(node.left);
                }
                
                if(node.right!=null){
                    queue.Enqueue(node.right);
                }
            }
            result.Add(max);
            max = int.MinValue;
        }
        
        return  result;
    }
}