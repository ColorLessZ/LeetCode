public class Solution {
    public IList<IList<int>> FindSubsequences(int[] nums) {
        var results = new List<IList<int>>();
        var holder = new List<int>();
        FindSubsequencesHelper(results, holder, 0, nums);
        return results;
    }
    
    private void FindSubsequencesHelper(List<IList<int>> results, List<int> holder, int startIndex, int[] nums){
        if(holder.Count >= 2) {
            results.Add(new List<int>(holder));
        }
        var used = new HashSet<int>();
        for (int i = startIndex; i < nums.Length; i++) {
            if (used.Contains(nums[i])) {
                continue;
            }
            if (holder.Count == 0 || holder[holder.Count - 1] <= nums[i]) {
                used.Add(nums[i]);
                holder.Add(nums[i]);
                FindSubsequencesHelper(results, holder, i + 1, nums);
                holder.RemoveAt(holder.Count - 1);
            }
        }
    }
}