public class Solution {
    public int MissingNumber(int[] nums) {
        var size = nums.Length + 1;
        var sum = size*(size-1)/2;
        foreach(var num in nums) {
            sum -= num;
        }
        
        return sum;
    }
}