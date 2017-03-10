public class Solution {
    public bool CanPartition(int[] nums) {
        var sum = 0;
        foreach(var n in nums) {
            sum +=n;
        }
        
        if (sum%2 != 0) {
            return false;
        }
        
        var target = sum/2;
        var dp = new bool[target+1];
        dp[0]=true;
        
        foreach(var num in nums) {
            for(int i = target; i>0; i--) {
                if (i >= num) {
                    dp[i] = dp[i] || dp[i-num];
                }
            }
        }
        
        return dp[target];
    }
}