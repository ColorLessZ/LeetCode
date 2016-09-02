public class Solution {
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        Array.Sort(candidates);
        var results = new List<IList<int>>();
        var list = new List<int>();
        CombinationSum2Helper(results, list, candidates, 0, target);
        return results;
    }
    
    private void CombinationSum2Helper(List<IList<int>> result, List<int> list, int[] candidates, int startIdx, int target){
        if (target < 0) {
            return;
        }
        
        int len = candidates.Length;
        if (target == 0) {
            var newList = new List<int>(list);
            result.Add(newList);
            return;
        }
        
        for (int i = startIdx; i < len; i++) {
            if (i > startIdx && candidates[i] == candidates[i-1]) {
                continue;
            }
            list.Add(candidates[i]);
            CombinationSum2Helper(result, list, candidates, i+1, target - candidates[i]);
            list.RemoveAt(list.Count-1);
        }
    }
}