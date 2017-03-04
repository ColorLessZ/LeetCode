public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        var list = new List<int>();
        foreach(var num in nums) {
            var index = Math.Abs(num) - 1;
            if (nums[index] > 0) {
                nums[index] *= -1;
            } else {
                list.Add(Math.Abs(index+1));
            }
        }
        
        return list;
    }
}