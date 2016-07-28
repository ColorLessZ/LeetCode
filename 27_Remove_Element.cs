public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int start = 0;
        int end = nums.Length - 1;
        while (start <= end) {
            if (nums[start] == val) {
                if (nums[end] != val) {
                    nums[start] = nums[end];
                    start++;
                    end--;
                } else {
                    end--;
                }
            } else {
                start++;
            }
        }
        
        return start;
    }
}