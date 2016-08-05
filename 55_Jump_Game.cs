public class Solution {
    public bool CanJump(int[] nums) {
        int dis = 0;
        int i = 0;
        while (i <= dis) {
            dis = Math.Max(dis, i + nums[i]);
            if (dis >= nums.Length-1) {
                return true;
            }
            i++;
        }
        return false;
        //return CanJumpHelper(nums, 0);
    }
    
    // private bool CanJumpHelper(int[] nums, int start) {
    //     var len = nums.Length;
    //     if (start > len - 1) {
    //         return false;
    //     }
        
    //     var val = nums[start];
    //     var delta = len - 1 -start;
    //     if (delta <= val) {
    //         return true;
    //     }
        
    //     var result = false;
    //     for(int i = 1; i <= val; i++) {
    //         result = result || CanJumpHelper(nums, start + i);
    //     }
        
    //     return result;
    // }
    
}