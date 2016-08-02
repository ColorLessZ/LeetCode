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
    public IList<int> RightSideView(TreeNode root) {
        var list = new List<int>();
        RightView(root, list, 0);
        return list;
    }
    
    private void RightView(TreeNode node, List<int> list, int currentHeight) {
        if (node == null) {
            return;
        }
        
        if (list.Count == currentHeight) {
            list.Add(node.val);
        }
        RightView(node.right, list, currentHeight + 1);
        RightView(node.left, list, currentHeight + 1);

    }
}

// public class Solution {
//     public IList<int> RightSideView(TreeNode root) {
//         var list = new List<int>();
//         var queue = new Queue<TreeNode>();
//         var subQueue = new Queue<TreeNode>();
//         if (root == null) {
//             return list;
//         }
//         queue.Enqueue(root);
//         while (queue.Count != 0) {
//             var size = queue.Count;
//             for(int i = 0; i < size; i++) {
//                 var node = queue.Dequeue();
//                 if (i == size - 1) {
//                     list.Add(node.val);
//                 }
//                 if (node.left != null) {
//                     subQueue.Enqueue(node.left);
//                 }
//                 if (node.right != null) {
//                     subQueue.Enqueue(node.right);
//                 }
//             }
//             while (subQueue.Count != 0) {
//                 queue.Enqueue(subQueue.Dequeue());
//             }
//         }
        
//         return list;
//     }
// }