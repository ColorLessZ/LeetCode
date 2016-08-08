public class Solution {
    public int MaxArea(int[] height) {
        var low = 0;
        var high = height.Length - 1;
        var max = (high - low) *Math.Min(height[high], height[low]);
        while (low < high) {
            if (height[high] < height[low]) {
                while ( high > low && height[high - 1] <= height[high]) {
                    high--;
                }
                high--;
                if (high > low) {
                    var val = (high - low) *Math.Min(height[high], height[low]);
                    max = Math.Max(max, val);
                }
                
            } else {
                while ( high > low && height[low + 1] <= height[low]) {
                    low++;
                }
                low++;
                if (high > low) {
                    var val = (high - low) *Math.Min(height[high], height[low]);
                    max = Math.Max(max, val);
                }
            }
        }
        
        return max;
    }
}