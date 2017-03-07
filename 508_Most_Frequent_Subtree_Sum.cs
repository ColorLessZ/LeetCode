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
    public int[] FindFrequentTreeSum(TreeNode root) {
        var list = new List<int>();
        var dic = new Dictionary<TreeNode, int>();
        var rootSum = GetSubTreeSum(root, dic);
        var frequent = new Dictionary<int, int>(); 
        foreach(var keyValue in dic) {
            var val = keyValue.Value;
            if (!frequent.ContainsKey(val)){
                frequent[val] = 0;
            }
            
            frequent[val] += 1;
        }
        var max = 0;
        foreach(var keyValue in frequent){
            var val = keyValue.Value;
            max = Math.Max(max, val);
        }
        
        foreach(var keyValue in frequent) {
            var val = keyValue.Value;
            var key = keyValue.Key;
            if (val == max) {
                list.Add(key);
            }
        }
        
        return list.ToArray();
        
    }
    
    private int GetSubTreeSum(TreeNode root, Dictionary<TreeNode, int> dic) {
        if (root == null){
            return 0;
        }
        if (dic.ContainsKey(root)) {
            return dic[root];
        }
        
        var left = root.left;
        var right = root.right;
        
        int leftVal = GetSubTreeSum(left,dic);
        
        int rightVal = GetSubTreeSum(right,dic);
        
        dic.Add(root, root.val + leftVal + rightVal);
        return root.val + leftVal + rightVal;
    }
}