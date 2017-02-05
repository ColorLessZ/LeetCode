public class Solution {
    public int FindTargetSumWays(int[] nums, int S) {
        return FindTargetSumWaysHelper(nums, 0, S);
    }
    
    private int FindTargetSumWaysHelper(int[] nums, int startIndex, int target) {
        var len = nums.Length;
        if (startIndex == len) {
            if (target == 0){
                return 1;
            } else {
                return 0;
            }
        } else {
            var val = nums[startIndex];
            return FindTargetSumWaysHelper(nums, startIndex+1, target+val) + FindTargetSumWaysHelper(nums,startIndex+1,target-val);
        }
    }
}