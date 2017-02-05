public class Solution {
    public int MaxProduct(int[] nums) {
        var len = nums.Length;
        var maxProduct = nums[0];
        var minProduct = nums[0];
        var result = nums[0];
        for(int i = 1; i < len; i++) {
            var val = nums[i];
            var maxProd = Math.Max(val,Math.Max(val*maxProduct,val*minProduct));
            var minProd = Math.Min(val,Math.Min(val*maxProduct,val*minProduct));
            maxProduct = maxProd;
            minProduct = minProd;
            result = Math.Max(result,Math.Max(maxProd,minProd));
        }
        
        return result;
    }
}