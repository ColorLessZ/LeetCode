public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var result = new int[2];
        var len = numbers.Length;
        var left = 0;
        var right = len - 1;
        while (left < right) {
            var val  = numbers[left] + numbers[right];
            if (val == target) {
                result[0] = left +1;
                result[1] = right +1;
                return result;
            } else if (val < target) {
                left += 1;
            } else {
                right -= 1;
            }
        }
        
        return result;
    }
}