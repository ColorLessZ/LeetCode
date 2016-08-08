public class Solution {
    Dictionary<int, int> cDic = new Dictionary<int,int>();
    public int CombinationSum4(int[] nums, int target) {
        if (target < 0) {
            return 0;
        }
        if (cDic.ContainsKey(target)) {
            return cDic[target];
        }
        
        if (target == 0) {
            return 1;
        }
        var result = 0;
        foreach(var num in nums) {
            result += CombinationSum4(nums, target - num);
        }
        cDic.Add(target, result);
        return result;
    }
}