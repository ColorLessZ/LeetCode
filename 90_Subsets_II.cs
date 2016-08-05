public class Solution {
    public IList<IList<int>> SubsetsWithDup(int[] nums) {
        Array.Sort(nums);
        var len = nums.Length;
        var result = new List<IList<int>>();
        result.Add(new List<int>());
        int i = 0;
        while (i < len) {
            var val = nums[i];
            var count = 1;
            while(i + 1 < len && nums[i] == nums[i+1]) {
                count += 1;
                i += 1;
            }
            
            var size = result.Count;
            var appendResult = new List<IList<int>>();
            for(int p = 0; p < size; p++) {
                var list = result[p];
                for(int j = 1; j <= count; j++) {
                    var newList = new List<int>(list);
                    var repeat = 1;
                    while(repeat <= j) {
                        newList.Add(val);
                        repeat+=1;
                    }
                    appendResult.Add(newList);
                }
            }
            
            foreach(var newResult in appendResult) {
                result.Add(newResult);
            }
            
            i += 1;
        }
        
        return result;
    }
}