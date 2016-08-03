public class Solution {
    public int MinPathSum(int[,] grid) {
        var h = grid.GetLength(0);
        var w = grid.GetLength(1);
        var result = new int[h,w];
        ////init result
        result[0,0] = grid[0,0];
        for(int i = 1; i < w; i++) {
            result[0,i] = result[0,i-1] + grid[0,i];
        }
        
        for(int i = 1; i < h; i++) {
            result[i,0] = result[i-1,0] + grid[i,0];
        }
        
        for (int i = 1; i < h; i++) {
            for (int j = 1; j < w; j++){
                result[i,j] = Math.Min(result[i-1,j], result[i,j-1]) + grid[i,j];
            }
        }
        
        return result[h-1,w-1];
    }
}