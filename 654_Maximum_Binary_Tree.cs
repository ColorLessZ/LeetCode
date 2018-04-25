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
    public TreeNode ConstructMaximumBinaryTree(int[] nums) {
        return BuildMaxBinaryTree(nums, 0, nums.Length - 1);
    }
    
    private TreeNode BuildMaxBinaryTree(int[] nums, int start, int end){
        if (start < 0 || end > nums.Length - 1 || start > end) {
            return null;
        }
        
        var maxIndex = FindMax(nums, start, end);
        var node = new TreeNode(nums[maxIndex]);
        node.left = BuildMaxBinaryTree(nums, start, maxIndex - 1);
        node.right = BuildMaxBinaryTree(nums, maxIndex + 1, end);
        return node;
    }
    
    private int FindMax(int[] nums, int start, int end){
        var max = nums[start];
        var maxIndex = start;
        for (int i = start; i<= end; i++){
            if (nums[i] > max){
                max = nums[i];
                maxIndex = i;
            }
        }
        
        return maxIndex;
    }
}