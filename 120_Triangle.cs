public class Solution {
    public int MinimumTotal(IList<IList<int>> triangle) {
        var rowCount = triangle.Count;
        var list = new List<int>();
        for(int i = 0; i < rowCount; i++){
            list.Add(Int32.MaxValue);
        }
        
        var minSum = Int32.MaxValue;
        for(int i = 0; i < rowCount; i++){
            var elem = triangle[i];
            var count = elem.Count;
            for (int j = count - 1; j >= 0; j--) {
                var min_1 = (j-1 < 0) ? Int32.MaxValue : list[j-1];
                var min0 = list[j];
                var temp = Math.Min(min_1, min0);
                var min = elem[j]  + (temp == Int32.MaxValue ? 0 : temp);
                list[j] = min;
            }
        }
        
        foreach(var v in list) {
            if (v < minSum) {
                minSum = v;
            }
        }
        
        return minSum;
    }
}