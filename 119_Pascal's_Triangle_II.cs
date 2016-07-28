public class Solution {
    public IList<int> GetRow(int rowIndex) {
        int[] result = Enumerable.Repeat(0, rowIndex + 1).ToArray();
        result[0] = 1;
        for (int i = 1 ; i < rowIndex + 1; i++) {
            for (int j = i; j >= 1; j--){
                result[j] += result[j-1];
            }
        }
        
        return result.ToList();
    }
}