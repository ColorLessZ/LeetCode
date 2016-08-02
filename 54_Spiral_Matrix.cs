public class Solution {
    public IList<int> SpiralOrder(int[,] matrix) {
        var height = matrix.GetLength(0);
        var width = matrix.GetLength(1);
        var rowStart = 0;
        var rowEnd = width - 1;
        var colStart = 0;
        var colEnd = height - 1;
        var list = new List<int>();
        while (rowStart <= rowEnd && colStart <= colEnd) {
            for(int i = rowStart; i <= rowEnd; i++) {
                list.Add(matrix[colStart,i]);
            }
            colStart += 1;
            
            for(int i = colStart; i <= colEnd; i++) {
                list.Add(matrix[i,rowEnd]);
            }
            rowEnd -= 1;
            
            if(colStart > colEnd) break;
            for(int i = rowEnd; i >= rowStart; i--) {
                list.Add(matrix[colEnd,i]);
            }
            colEnd -= 1;
            
            if(rowStart > rowEnd) break;
            for(int i = colEnd; i >= colStart; i--) {
                list.Add(matrix[i,rowStart]);
            }
            rowStart += 1;
        }
        
        return list;
    }
}