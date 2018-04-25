public class Solution {
    public int NumSubarrayProductLessThanK(int[] nums, int k) {
        var start = 0;
        var end = 0;
        var count = 0;
        var prod = 1;
        for (int i = 0 ; i < nums.Length; i++){
            end = i;
            prod *= nums[end];
            while(prod >= k){
                prod /= nums[start];
                start += 1;
            }
            count += end - start + 1;
        }
        
        return count;
    }
}