public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dic = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++) {
            var n = nums[i];
            var delta = target - n;
            if (dic.ContainsKey(n)) {
                return new int[2]{dic[n], i};
            } else {
                dic[delta] = i;
            }
        }
        
        return new int[0];
    }
}