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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        var list = new List<IList<int>>();
        var queue = new Queue<TreeNode>();
        if (root == null) {
            return list;
        }
        
        queue.Enqueue(root);
        while(queue.Count() != 0) {
            var size = queue.Count();
            var subList = new List<int>();
            var subQueue = new Queue<TreeNode>();
            for (int i = 0; i < size; i++) {
                var node = queue.Dequeue();
                subList.Add(node.val);
                if (node.left != null) {
                    subQueue.Enqueue(node.left);
                }
                if (node.right != null) {
                    subQueue.Enqueue(node.right);
                }
            }
            while (subQueue.Count() != 0) {
                queue.Enqueue(subQueue.Dequeue());
            }
            list.Add(subList);
        }
        
        return list;
    }
}