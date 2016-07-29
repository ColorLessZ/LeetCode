public class Solution {
    public int SingleNumber(int[] nums) {
        int result = 0;
        foreach(var n in nums) {
            result = result^n;
        }
        
        return result;
    }
}