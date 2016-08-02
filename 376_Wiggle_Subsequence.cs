public class Solution {
    public int WiggleMaxLength(int[] nums) {
        var total = 1;
        var len = nums.Length;
        if (len == 0) {
            return 0;
        }
        int isPrePos = 0;
        for (int i = 1; i < len; i++) {
            var delta = nums[i] - nums[i-1];
            if (delta > 0) {
                if (isPrePos != 1) {
                    total += 1;
                    isPrePos = 1;
                }
            } else if (delta < 0) {
                if (isPrePos != 2) {
                    total += 1;
                    isPrePos = 2;
                }
            }
        }
        
        return total;
    }
}