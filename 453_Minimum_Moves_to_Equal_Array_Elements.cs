public class Solution {
    public int MinMoves(int[] nums) {
        var min = int.MaxValue;
        var len = nums.Length;
        var sum = 0;
        for(int i = 0; i < len; i++) {
            min = Math.Min(min, nums[i]);
            sum += nums[i];
        }
        
        return sum - len*min;
    }
}