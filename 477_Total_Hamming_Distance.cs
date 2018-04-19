public class Solution {
    public int TotalHammingDistance(int[] nums) {
        var distance = 0;
        var numCount = nums.Length;
        for(int i = 0; i < 32; i++){
            var oneCount = 0;
            foreach(var num in nums){                
                oneCount += (num >> i & 1);
            }
            distance += oneCount*(numCount - oneCount);
        }
        
        return distance;
    }
}