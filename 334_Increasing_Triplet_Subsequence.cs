public class Solution {
    public bool IncreasingTriplet(int[] nums) {
        var len = nums.Length;
        if (len < 3) {
            return false;
        }
        
        var result = new int[len];
        result[0] = 1;
        for(int i = 1; i < len; i++) {
            var localMax = 1;
            for (int j = 0; j < i; j ++) {
                if (nums[j] < nums[i]) {
                    localMax = Math.Max(result[j] + 1, localMax);
                }
            }
            
            if (localMax >= 3){
                return true;
            }
            
            result[i] = localMax;
        }
        
        return false;
    }
}