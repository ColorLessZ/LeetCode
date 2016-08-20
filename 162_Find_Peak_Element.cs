public class Solution {
    public int FindPeakElement(int[] nums) {
        var low = 0;
        var high = nums.Length -1;
        while (low < high) {
            var midHigh = high - (high-low)/2;
            var midLow = midHigh - 1;
            if (nums[midLow] > nums[midHigh]){
                high = midLow;
            } else {
                low = midHigh;
            }
        }
        
        return low;
    }
}