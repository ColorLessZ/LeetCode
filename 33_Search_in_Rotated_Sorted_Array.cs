public class Solution {
    public int Search(int[] nums, int target) {        
        var start = 0;
        var end = nums.Length - 1;
        if (end < 0){
            return -1;
        }
        
        while (start + 1 < end){
            var mid = (end + start) / 2;
            
            if (target == nums[start]) {
                return start;
            }
            
            if (target == nums[mid]) {
                return mid;
            }
            
            if (target == nums[end]) {
                return end;
            }
            
            if (target > nums[start] && target > nums[end]){
                if (target < nums[mid]){
                    end = mid;
                } else {
                    if (nums[mid] > nums[start]) {
                        start = mid;
                    } else {
                        end = mid;
                    }
                }                
            } else if (target < nums[start] && target < nums[end]) {
                 if (target > nums[mid]) {
                      start = mid;
                 } else {
                     if (nums[mid] > nums[start]) {
                        start = mid;   
                     } else {
                         end = mid;
                     }
                 }
            } else {
                if (target > nums [mid]){
                    start = mid;
                } else {
                    end = mid;
                }
            }
        }
        
        if (target == nums[start]) {
             return start;
        }
        
        if (target == nums[end]){
            return end;
        }
        
        return -1;
    }
}