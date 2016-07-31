public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
      var len = nums.Length;
      var results = new List<IList<int>>();
      for(int i = 0; i < Math.Pow(2,len); i++) {
          var result = new List<int>();
          var b = new BitArray(new int[] { i });
          for(int j = 0; j < len; j++) {
              if (b[j]) {
                  result.Add(nums[j]);
              }
          }
          results.Add(result);
      }
      
      return results;
    }
}