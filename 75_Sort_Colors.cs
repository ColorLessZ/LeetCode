public class Solution {
    public void SortColors(int[] nums) {
        var start = 0;
        var end = nums.Length - 1;
        for (int i = 0 ; i<=end ; i++) {
            var val = nums[i];
            if (val == 0 && i > start) {
                nums[i] = nums[start];
                nums[start] = 0;
                start += 1;
                i-=1;
            } else if (val == 2 && i < end) {
                nums[i] = nums[end];
                nums[end] = 2;
                end -= 1;
                i -= 1;
            }
        }
    }
}