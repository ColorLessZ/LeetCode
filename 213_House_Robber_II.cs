public class Solution {
    public int Rob(int[] nums) {
        if (nums.Length == 0) return 0;
        if (nums.Length == 1) return nums[0];
        return Math.Max(Rob(nums, 0, nums.Length - 2), Rob(nums, 1, nums.Length - 1));
    }
    
    public int Rob(int[] nums, int start, int end) 
    {
        int prev1 = 0;
        int prev2 = 0;
        int curr = 0;
        for (int i = start; i <= end; i++)
        {
            curr = Math.Max(nums[i] + prev2, prev1);
            prev2 = prev1;
            prev1 = curr;
        }
        return curr;
    }
}