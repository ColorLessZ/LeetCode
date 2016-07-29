public class Solution {
    public IList<int> TopKFrequent(int[] nums, int k) {
        var feq = new Dictionary<int, int>();
        foreach(var num in nums) {
            if (feq.ContainsKey(num)) {
                feq[num] += 1;
            } else {
                feq.Add(num, 1);
            }
        }
        
        var list = new List<int>[nums.Length];
        
        foreach(KeyValuePair<int, int> f in feq){
            if (list[f.Value - 1] == null) {
                list[f.Value - 1] = new List<int>();
                
            }
            
            list[f.Value - 1].Add(f.Key);
        }
        var count = 0;
        var result = new List<int>();
        for (int i = list.Length - 1; i >= 0 && result.Count < k; i--) {
    		if (list[i] != null) {
    			result.AddRange(list[i]);
    		}
    	}
    	
    	return result;
    }
}