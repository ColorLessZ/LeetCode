public class Solution {
    public int MaxSubArray(int[] nums) {
        var len = nums.Length;
        var max = Int32.MinValue;
        var maxArray = new int[len];
        maxArray[0] = nums[0];
        max = nums[0];
        for(int i = 1; i < len; i++) {
            maxArray[i] = Math.Max(nums[i] + maxArray[i-1], nums[i]);
            max = Math.Max(maxArray[i], max);
        }
        
        return max;
    }
}