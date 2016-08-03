public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        var result = new List<IList<int>>();
        for (int i = 0; i < nums.Length - 2; i++) {
            var start = i + 1;
            var end = nums.Length -1;
            if (i == 0 || nums[i] != nums[i-1]) {
                while (start < end) {
                    if (nums[i] + nums[start] + nums[end] == 0) {
                        var list = new List<int>();
                        list.Add(nums[start]);
                        list.Add(nums[i]);
                        list.Add(nums[end]);
                        result.Add(list);
                        while (start < end && nums[start] == nums[start+1]) {
                            start++;
                        }
                        while (start < end && nums[end] == nums[end-1]) {
                            end--;
                        }
                        start++;
                        end--;
                    } else if (nums[i] + nums[start] + nums[end] < 0) {
                        start++;
                    } else {
                        end--;
                    }
                }
            }
        }
        
        return result;
    }
}