public class Solution {
    public int[,] UpdateMatrix(int[,] matrix) {
        var height = matrix.GetLength(0);
        var width = matrix.GetLength(1);
        var result = new int[height,width];
        for(int i = 0; i < height; i++){
            for(int j = 0; j < width; j++){
                if(matrix[i,j] != 0){
                    var top = int.MaxValue - 1;
                    var left = int.MaxValue - 1;
                    if(i - 1 >= 0){
                        top = result[i-1,j];
                    }
                    if (j -1 >= 0){
                        left = result[i, j-1];
                    }
                    result[i,j] = Math.Min(int.MaxValue-1, Math.Min(top,left) + 1);
                } else {
                    result[i,j] = 0;
                }
            }
        }
        
        for(int i = height - 1; i >= 0; i--){
            for(int j = width - 1; j >= 0; j--){
                var down = int.MaxValue - 1;
                var right = int.MaxValue - 1; 
                if(i+1 < height){
                    down = result[i+1,j];
                }
                if(j+1 < width){
                    right = result[i,j+1];
                }
                
                result[i,j] = Math.Min(result[i,j], Math.Min(down+1, right+1));
            }
        }
        
        return result;
    }
}

