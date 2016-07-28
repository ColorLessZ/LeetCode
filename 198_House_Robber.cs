public class Solution {
    public int Rob(int[] nums) {
        int len = nums.Length;
        if (len==0) {
            return 0;
        }
        if (len == 1) {
            return nums[0];
        }
        
        var s = new List<int>();
        for(int i=0 ; i<=len; i++)
        {
            s.Add(0);
        }
        s[1] = nums[0];
        s[2] = nums[1];
        for (int i=3;i<=len;i++){
            s[i] = Math.Max(s[i-2],s[i-3]) + nums[i-1];
        }
        return Math.Max(s[len-1],s[len]);
    }
}