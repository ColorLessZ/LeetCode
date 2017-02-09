public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        var max = 0;
        var currentMax = 0;
        foreach(var num in nums) {
            currentMax = num == 0 ? 0 : currentMax+1;
            max = Math.Max(max, currentMax);
        }
        
        return max;
    }
}