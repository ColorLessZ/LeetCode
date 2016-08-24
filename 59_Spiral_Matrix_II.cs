public class Solution {
    public int[,] GenerateMatrix(int n) {
        var result = new int[n,n];
        var count = 1;
        var rowStart = 0;
        var colStart = 0;
        var rowEnd = n-1;
        var colEnd = n-1;
        while (rowStart <= rowEnd && colStart <= colEnd) {
            for (int i = colStart; i <= colEnd; i++) {
                result[rowStart,i] = count;
                count++;
            }
            rowStart++;
            
            for(int i = rowStart; i <= rowEnd; i++){
                result[i,colEnd] = count;
                count++;
            }
            colEnd--;
            
            for(int i = colEnd; i >= colStart; i--){
                result[rowEnd,i] = count;
                count++;
            }
            rowEnd--;
            
            for(int i = rowEnd; i >= rowStart; i--){
                result[i,colStart] = count;
                count++;
            }
            colStart++;
        }
        
        return result;
    }
}