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
    public TreeNode SortedArrayToBST(int[] nums) {
        var low = 0;
        var high = nums.Length - 1;
        return GetTreeNode(nums, low, high);
    }
    
    private TreeNode GetTreeNode(int[] nums, int low, int high) {
        if (low > high) {
            return null;
        }
        var mid = high - (high -low)/2;
        var root = new TreeNode(nums[mid]);
        if (mid - 1 >= low) {
            root.left = GetTreeNode(nums, low, mid - 1);
        }
        
        if (mid + 1 <= high) {
            root.right = GetTreeNode(nums, mid + 1, high);
        }
        return root;
    }
    
}