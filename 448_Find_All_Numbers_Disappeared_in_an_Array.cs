public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        var list = new List<int>();
        for(int i = 0; i < nums.Length; i++) {
            var val = Math.Abs(nums[i]);
            if (nums[(val-1)] > 0) {
                nums[(val-1)] = nums[(val-1)]*-1;
            }
        }
        
        for(int i = 0; i < nums.Length; i++) {
            var val = nums[i];
            if (val > 0) {
                list.Add(i+1);
            }
        }
        
        return list;
    }
}