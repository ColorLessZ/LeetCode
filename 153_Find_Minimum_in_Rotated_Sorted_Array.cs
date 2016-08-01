public class Solution {
    public int FindMin(int[] nums) {
        var low = 0;
        var high = nums.Length - 1;
        while (low < high - 1) {
            if (nums[low] < nums[high]) {
                return nums[low];
            }
            
            var mid = high - (high - low)/2;
            if (nums[low] > nums[mid]) {
                high = mid;
            }
            
            if (nums[mid] > nums[high]) {
                low = mid;
            }
        }
        
        return nums[high] > nums[low] ? nums[low] : nums[high];
    }
}