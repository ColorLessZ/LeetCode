public class Solution {
    public int SearchInsert(int[] nums, int target) {
        var low = 0;
        var high = nums.Length - 1;
        while (low <= high) {
            var mid = high - (high - low)/2;
            var val = nums[mid];
            if (target == val) {
                return mid;
            }
            
            if (target < val) {
                if (mid - 1 >= 0) {
                    if (target > nums[mid -1]) {
                        return mid;
                    } else {
                        high = mid - 1; 
                    }
                } else {
                    return 0;
                }
            }
            
            if (target > val) {
                if (mid + 1 <= nums.Length -1) {
                    if (target < nums[mid + 1] ) {
                        return mid + 1;
                    } else {
                        low = mid + 1;
                    } 
                } else {
                    return nums.Length;
                }
            }
        }
        
        if (low == 0 && target <= nums[0]) {
            return 0;
        }
        
        return nums.Length;
        
    }
}