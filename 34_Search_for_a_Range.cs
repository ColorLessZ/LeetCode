public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        
        var start = 0;
        var len = nums.Length;
        var end = nums.Length - 1;
        var result = new int[2]{-1,-1};
        if (target < nums[0] || target > nums[len-1]) {
            return result;
        }
        
        var index = -1;
        while(start < end) {
            var mid = end - (end-start)/2 - 1;
            if (nums[mid] < target) {
                start = mid + 1;
            } else {
                end = mid;
            }
        }
        
        if (nums[start] != target) {
            return result;
        }
        result[0] = start;
        end = nums.Length - 1;
        while(start < end) {
            var mid = end - (end-start)/2;
            if (nums[mid] > target) {
                end = mid - 1;
            } else {
                start = mid;
            }
        }
        result[1] = end;
        return result;
        
    }
}