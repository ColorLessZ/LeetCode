public class Solution {
    public IList<IList<int>> CombinationSum3(int k, int n) {
        var result = new List<IList<int>>();
        var list = new List<int>();
        CombinationSum3Helper(result, list, k, 1, n);
        return result;
    }
    
    private void CombinationSum3Helper(List<IList<int>> result, List<int> list, int k, int start, int n) {
        //base case :find a solution
        if (list.Count == k && n == 0) {
            var temp = new List<int>(list);
            result.Add(temp);
            return;
        }
        
        //// varible start here is to remove dups
        for (int i = start; i<=9; i++){
            list.Add(i);
            CombinationSum3Helper(result, list, k, i + 1, n -i);
            list.Remove(list.Last());
        }
    }
    
}