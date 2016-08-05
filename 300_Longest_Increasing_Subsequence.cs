////Need to re do in NlogN in next round
public class Solution {
    public int LengthOfLIS(int[] nums) {
        var len = nums.Length;
        if (len == 0) {
            return 0;
        }
        
        var result = new int[len];
        result[0] = 1;
        var max = result[0];
        for (int i = 1; i < len; i++) {
            var localMax = 1;
            for (int j = 0; j < i; j++) {
                if (nums[i] > nums[j]) {
                    localMax = Math.Max(localMax, result[j] + 1);
                }
            }
            result[i] = localMax;
            max = Math.Max(localMax, max);
        }
        
        return max;
    }
}