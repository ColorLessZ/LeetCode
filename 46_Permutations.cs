public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        var result = new List<IList<int>>();
        var list = new List<int>();
        var num0 = nums[0];
        list.Add(num0);
        result.Add(list);
        for (int i = 1; i < nums.Length; i++) {
            var newResult = new List<IList<int>>();
            var newVal = nums[i];
            for (int j = 0; j < result.Count; j++) {
                var oldList = result[j];
                var newList = new List<int>(oldList);
                newList.Add(newVal);
                newResult.Add(newList);
                foreach(var elem in oldList) {
                    int index = oldList.IndexOf(elem);
                    var nl = new List<int>(oldList);
                    nl.Insert(index, newVal);
                    newResult.Add(nl);
                }
            }
            result = newResult;
        }
        
        return result;
    }
}